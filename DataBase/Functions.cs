using Practice.DataBase.Entities;
using Practice.Forms;
using System.IO;

namespace Practice.DataBase;
internal class Functions
{
    public static bool Login(string login, string password)
    {
        try
        {
            using var context = new Context();
            if (!context.Users.Any(x => x.Login == login))
                throw new Exception("Пользователь не найден");

            var user = context.Users.Single(x => x.Login == login);

            if (user.Password != password)
                throw new Exception("Неверный пароль");

            Program.Session = user;
            return true;
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
            return false;
        }
    }
    public static bool Register(string login, string password, string name, string surname, string email, int accessLevel = 0)
    {
        using var context = new Context();
        if (context.Users.Any(x => x.Login == login) ||
            context.Users.Any(x => x.Email.ToLower() == email.ToLower()))
        {
            MessageBox.Show("Пользователь с таким логином или почтой уже существует!");
            return false;
        }                

        var user = new User()
        {
            Login = login,
            Password = password,
            Name = name,
            Surname = surname,
            Email = email,
            AccessLevel = accessLevel
        };
        context.Users.Add(user);
        context.SaveChanges();
        
        return true;
    }
    public static bool IsMySchedule(User worker)
    {
        var currentTime = DateTime.Now;
        using var context = new Context();

        if (!context.Schedules
            .Any(x => x.StartTime < currentTime && x.EndTime > currentTime))
            return false;
        var currentSchedule = GetCurrentSchedule();

        return context.ScheduleWorkers
            .Any(x => x.WorkerId == worker.Id && x.ScheduleId == currentSchedule.Id);
    }
    public static void ChangeUserLevel(int userid, int level)
    {
        using var context = new Context();
        var user = context.Users.First(x => x.Id == userid);
        user.AccessLevel = level;

        context.SaveChanges();
    }
    public static void AddUserToSchedule(User user, Schedule schedule)
    {
        using var context = new Context();
        var worker = new ScheduleWorkers()
        {
            ScheduleId = schedule.Id,
            WorkerId = user.Id
        };
        context.ScheduleWorkers.Add(worker);

        context.SaveChanges();
    }
    public static void AddOrder(Order order) 
    {
        using var context = new Context();
        context.Orders.Add(order);

        context.SaveChanges();
    }
    public static void ChangeOrderStatus(Order order, string status)
    {
        using var context = new Context();
        order.Status = status;
        context.Orders.Update(order);

        context.SaveChanges();
    }
    public static void CreateSchedule(DateTime start, DateTime end, User manager)
    {
        using var context = new Context();
        context.Schedules.Add(new Schedule
        {
            StartTime = start,
            EndTime = end,
            ManagerId = manager.Id,
        });

        context.SaveChanges();
    }
    public static User GetUserById(int id)
    {
        using var context = new Context();
        return context.Users.First(x => x.Id == id);
    }
    public static User[] GetAllUsers()
    {
        using var context = new Context();
        return context.Users.ToArray();
    }
    public static User[] GetAllManagers()
    {
        using var context = new Context();
        return context.Users
            .Where(x => x.AccessLevel == (int)AccessLevels.Manager)
            .ToArray();
    }
    public static User[] GetAllWorkers()
    {
        using var context = new Context();
        return context.Users
            .Where(x => x.AccessLevel == (int)AccessLevels.Worker)
            .ToArray();
    }
    public static User[] GetScheduleWorkers(Schedule schedule)
    {
        using var context = new Context();
        var workersIds = context.ScheduleWorkers
            .Where(x => x.ScheduleId == schedule.Id)
            .Select(x => x.WorkerId);
        var workers = workersIds
            .Select(id => context.Users.First(x => x.Id == id));

        return workers.ToArray();
    }
    public static Schedule GetCurrentSchedule()
    {
        var currentTime = DateTime.Now;

        using var context = new Context();
        if (!context.Schedules
            .Any(x => x.StartTime < currentTime && x.EndTime > currentTime))
            return null;
        return context.Schedules
            .First(x => x.StartTime < currentTime && x.EndTime > currentTime);
    }
    public static Schedule[] GetActiveSchedules()
    {
        using var context = new Context();
        var schedules = context.Schedules
            .Where(x => x.EndTime > DateTime.Now)
            .ToList();

        schedules.Sort(delegate (Schedule x, Schedule y)
        {
            return x.StartTime.CompareTo(y.StartTime);
        });
        return schedules.ToArray();
    }
    public static Schedule[] GetMySchedules(User user)
    {
        using var context = new Context();
        return context.Schedules
            .Where(x => x.ManagerId == user.Id)
            .ToArray();
    }
    public static Order[] GetAllOrders()
    {
        using var context = new Context();
        return context.Orders.ToArray();
    }
    public static Order[] GetWorkingOrders()
    {
        using var context = new Context();
        return context.Orders
            .Where(x =>
                x.Status != "Отменен" &&
                x.Status != "Выполнен").ToArray();
    }
}
