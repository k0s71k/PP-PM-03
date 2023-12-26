namespace Practice.Forms.Admin;
public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void OnScheduleClick(object sender, EventArgs e)
    {
        this.Hide();
        new Schedules().Show();
    }

    private void OnUsersClick(object sender, EventArgs e)
    {
        this.Hide();
        new Users().Show();
    }
}
