using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Web.Models;

[Table("settings")]
public class Settings
{
    [Key][Column("id")] public int Id { get; set; }

    [Column("salon_name")][MaxLength(150)] public string SalonName { get; set; } = "Салон красоты «Багира»";

    [Column("logo_path")][MaxLength(255)] public string? LogoPath { get; set; }

    [Column("background_path")][MaxLength(255)] public string? BackgroundPath { get; set; }

    [Column("phone")][MaxLength(20)] public string? Phone { get; set; }

    [Column("email")][MaxLength(100)] public string? Email { get; set; }

    [Column("address")] public string? Address { get; set; }
}