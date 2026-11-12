using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Web.Models;

[Table("client")]
public class Client
{
    [Key][Column("id")] public int Id { get; set; }

    [Column("full_name")][Required, MaxLength(150)] public string FullName { get; set; } = "";

    [Column("phone")][Required, MaxLength(20)] public string Phone { get; set; } = "";

    [Column("email")][MaxLength(100)] public string? Email { get; set; }

    [Column("birth_date")] public DateTime? BirthDate { get; set; }

    [Column("notes")] public string? Notes { get; set; }

    [Column("is_self_booked")] public bool IsSelfBooked { get; set; }

    [Column("preferred_master_id")] public int? PreferredMasterId { get; set; }

    [Column("registration_date")] public DateTime RegistrationDate { get; set; } = DateTime.Now;
}