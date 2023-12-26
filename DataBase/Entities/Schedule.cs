using System.ComponentModel.DataAnnotations;

namespace Practice.DataBase.Entities;
internal class Schedule
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime StartTime { get; set; }
    [Required]
    public DateTime EndTime { get; set; }
    [Required]
    public int ManagerId { get; set; }

    public override string ToString()
        => $"{StartTime.ToString("dd.MM.yyyy")} - [{StartTime.ToString("HH:mm")}; {EndTime.ToString("HH:mm")}]";
}
