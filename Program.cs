using Practice.DataBase;
using Practice.DataBase.Entities;
using System.Linq;

namespace Practice;
public enum AccessLevels
{
    Dismissed = -1,
    Default = 0,
    Worker = 1,
    Manager = 2,
    Administrator = 3
}
internal static class Program
{
    public static User? Session;
    [STAThread]
    public static void Main()
    {
        InitDatabase();
        ApplicationConfiguration.Initialize();
        Application.Run(new Login());
    }

    private static void InitDatabase()
    {
        using var context = new Context();
        context.Database.EnsureCreated();
    }
    public static string ConvertAccessLevel(int level)
    {
        switch (level)
        {
            case (int)AccessLevels.Administrator: 
                return "�������������";
            case (int)AccessLevels.Manager:
                return "��������";
            case (int)AccessLevels.Worker:
                return "���������";
            case (int)AccessLevels.Dismissed:
                return "������";
            default:
                return "�� ����������";
        }
    }
}