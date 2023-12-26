using Microsoft.EntityFrameworkCore;
using Practice.DataBase.Entities;

namespace Practice.DataBase;
internal class Context: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Practice;Trusted_Connection=True;");
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<ScheduleWorkers> ScheduleWorkers{ get; set; }
}
