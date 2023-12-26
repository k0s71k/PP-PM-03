using static Practice.DataBase.Functions;

namespace Practice;
public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void OnAuthorizeClick(object sender, EventArgs e)
    {
        var loggedIn = Login(
            login: LoginEdit.Text,
            password: PasswordEdit.Text);

        if (!loggedIn)
            return;

        this.Hide();
        switch (Program.Session.AccessLevel)
        {
            case (int)AccessLevels.Administrator:
                this.Hide();
                new Forms.Admin.Main().Show();
                break;
            case (int)AccessLevels.Manager:
                new Forms.Manager.Main().Show();
                break;
            case (int)AccessLevels.Worker:
                if (!IsMySchedule(Program.Session))
                    MessageBox.Show("Не ваша смена!");

                new Forms.Worker.Orders().Show();
                break;
            default:
                MessageBox.Show("Нет доступа!");
                break;
        }

    }
}
