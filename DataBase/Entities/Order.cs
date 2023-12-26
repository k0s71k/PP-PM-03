using System.ComponentModel.DataAnnotations;

namespace Practice.DataBase.Entities;
internal class Order
{
    [Key]
    public int OrderId { get; set; }
    [Required]
    public int ClientId { get; set; }
    [Required]
    public string? Status { get; set; }
    [Required]
    public string Description { get; set; }

    public override string ToString()
        => $"[{this.OrderId}] {this.Description} ({this.Status})";
}
