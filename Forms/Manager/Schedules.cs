using Practice.DataBase.Entities;
using static Practice.DataBase.Functions;

namespace Practice.Forms.Manager
{
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
            InitMenu();
        }
        private void InitMenu()
        {
            UsersList.Items.Clear();
            UsersList.Items.AddRange(GetAllWorkers());

            SchedulesList.Items.Clear();
            SchedulesList.Items.AddRange(GetMySchedules(Program.Session));
        }
        private void OnScheduleChange(object sender, EventArgs e)
        {
            if (SchedulesList.SelectedItem == null)
                return;
            var choosedSchedule = (Schedule)SchedulesList.SelectedItem;
            WorkersList.Items.Clear();
            WorkersList.Items.AddRange(GetScheduleWorkers(choosedSchedule));
        }

        private void OnAddWorkerClick(object sender, EventArgs e)
        {
            if (UsersList.SelectedItem == null || SchedulesList.SelectedItem == null)
                return;

            AddUserToSchedule(
                (User)UsersList.SelectedItem,
                (Schedule)SchedulesList.SelectedItem);

            InitMenu();
        }
    }
}
