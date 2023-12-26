using static Practice.Program;

namespace Practice.Forms;
public partial class CreateUser : Form
{
    private class AccessLevel
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public override string ToString()
            => this.Name;
    }
    public CreateUser()
    {
        InitializeComponent();
        InitMenu();
    }
    private void OnRegisterClick(object sender, EventArgs e)
    {
        if (LevelsCombo.SelectedItem == null)
            return;
        var level = (AccessLevel)LevelsCombo.SelectedItem;

        if (!Practice.DataBase.Functions.Register(
            login:      LoginEdit.Text,
            password:   PasswordEdit.Text,
            name:       NameEdit.Text,
            surname:    SurnameEdit.Text,
            email:      EmailEdit.Text,
            accessLevel:level.Value))
            return;

        this.Hide();
        new Users().Show();
    }
    private void InitMenu()
    {
        LevelsCombo.Items.Clear();
        LevelsCombo.Items.AddRange(new AccessLevel[]
        {
            new AccessLevel
            {
                Value = (int)AccessLevels.Worker,
                Name = ConvertAccessLevel((int)AccessLevels.Worker)
            },
            new AccessLevel
            {
                Value = (int)AccessLevels.Manager,
                Name = ConvertAccessLevel((int)AccessLevels.Manager)
            },
            new AccessLevel
            {
                Value = (int)AccessLevels.Administrator,
                Name = ConvertAccessLevel((int)AccessLevels.Administrator)
            }
        });
    }
}
