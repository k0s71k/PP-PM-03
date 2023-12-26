using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Practice.DataBase.Entities;
internal class ScheduleWorkers
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int ScheduleId { get; set; }
    [Required]
    public int WorkerId { get; set; }
}
