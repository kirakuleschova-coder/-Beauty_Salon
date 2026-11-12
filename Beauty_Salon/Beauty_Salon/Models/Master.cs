using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Web.Models;

[Table("master")]
public class Master
{
    [Key][Column("id")] public int Id { get; set; }

    [Column("full_name")][Required, MaxLength(150)] public string FullName { get; set; } = "";

    [Column("specialization")][Required, MaxLength(100)] public string Specialization { get; set; } = "";

    [Column("phone")][MaxLength(20)] public string? Phone { get; set; }

    [Column("schedule")] public string? Schedule { get; set; }

    [Column("photo_path")][MaxLength(255)] public string? PhotoPath { get; set; }

    [Column("is_active")] public bool IsActive { get; set; } = true;
}