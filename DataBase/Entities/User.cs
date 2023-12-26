using System.ComponentModel.DataAnnotations;
using static Practice.Program;

namespace Practice.DataBase.Entities;
internal class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Login { get; set; }
    [Required]
    public string? Password { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Surname { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public int AccessLevel { get; set; }

    public override string ToString()
        => $"{this.Id}: {this.Name} {this.Surname} ({ConvertAccessLevel(this.AccessLevel)})";
}