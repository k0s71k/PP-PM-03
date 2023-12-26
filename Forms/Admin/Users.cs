using Practice.DataBase.Entities;
using static Practice.DataBase.Functions;
using static Practice.Program;

namespace Practice.Forms;
public partial class Users : Form
{
    public Users()
    {
        InitializeComponent();
        InitMenu();
    }
    private class AccessLevel
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public override string ToString()
            => this.Name;
    }
    private void InitMenu()
    {
        UsersList.Items.Clear();
        UsersList.Items.AddRange(GetAllUsers());

        LevelsCombo.Items.Clear();
        LevelsCombo.Items.AddRange(new AccessLevel[]
        {
            new AccessLevel
            {
                Value = (int)AccessLevels.Dismissed,
                Name = ConvertAccessLevel((int)AccessLevels.Dismissed)
            },
            new AccessLevel
            {
                Value = (int)AccessLevels.Default,
                Name = ConvertAccessLevel((int)AccessLevels.Default)
            },
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

    private void OnChangeClick(object sender, EventArgs e)
    {
        if (UsersList.SelectedItem == null || LevelsCombo.SelectedItem == null)
            return;
        var selectedUser = (User)UsersList.SelectedItem;
        var currentLevel = selectedUser.AccessLevel;
        if (currentLevel == (int)AccessLevels.Administrator)
        {
            MessageBox.Show("Нельзя изменить уровень доступа для администратора");
            return;
        }

        var level = (AccessLevel)LevelsCombo.SelectedItem;
        var userid = selectedUser.Id;
        
        ChangeUserLevel(userid, level.Value);
        InitMenu();
        MessageBox.Show($"Уровень доступа для {selectedUser} изменен на \"{level.Name}\"");
    }

    private void OnCreateClick(object sender, EventArgs e)
    {
        this.Hide();
        new CreateUser().Show();
    }
}
