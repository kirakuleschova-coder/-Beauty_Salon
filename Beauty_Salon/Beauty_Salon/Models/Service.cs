using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Web.Models;

[Table("service")]
public class Service
{
    [Key][Column("id")] public int Id { get; set; }

    [Column("name")][Required, MaxLength(100)] public string Name { get; set; } = "";

    [Column("category")][Required, MaxLength(50)] public string Category { get; set; } = "";

    [Column("price")] public decimal Price { get; set; }

    [Column("duration")] public int Duration { get; set; }

    [Column("description")] public string? Description { get; set; }

    [Column("is_active")] public bool IsActive { get; set; } = true;
}