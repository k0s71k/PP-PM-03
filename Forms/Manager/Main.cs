namespace Practice.Forms.Manager;
public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void OnSchedulesClick(object sender, EventArgs e)
    {
        this.Hide();
        new Schedules().Show();
    }

    private void OnOrdersClick(object sender, EventArgs e)
    {
        this.Hide();
        new Orders().Show();
    }
}
