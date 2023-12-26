using Practice.DataBase.Entities;
using static Practice.DataBase.Functions;

namespace Practice.Forms
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
            SchedulesList.Items.Clear();
            SchedulesList.Items.AddRange(GetActiveSchedules());

            ManagerCombo.Items.Clear();
            ManagerCombo.Items.AddRange(GetAllManagers());
        }
        private void OnSchedulesChange(object sender, EventArgs e)
        {
            var currentItem = SchedulesList.SelectedItem;
            if (currentItem == null)
                return;

            var currentSchedule = (Schedule)currentItem;
            ManagerIdEdit.Visible = true;
            ManagerIdEdit.Text = GetUserById(currentSchedule.ManagerId)
                .ToString();

            var scheduleWorkers = GetScheduleWorkers(currentSchedule);
            WorkersList.Visible = true;
            WorkersList.Items.Clear();
            WorkersList.Items.AddRange(scheduleWorkers);
        }
        private void OnCreateClick(object sender, EventArgs e)
        {
            var date = DatePicker.Value;
            var start = StartTimePicker.Value;
            var end = EndTimePicker.Value;

            var startDateTime = new DateTime(date.Year, date.Month, date.Day, start.Hour, start.Minute, start.Second);
            var endDateTime = new DateTime(date.Year, date.Month, date.Day, end.Hour, end.Minute, end.Second);

            if (ManagerCombo.SelectedItem == null)
                return;

            var manager = (User)ManagerCombo.SelectedItem;
            CreateSchedule(startDateTime, endDateTime, manager);

            InitMenu();
        }
    }
}
