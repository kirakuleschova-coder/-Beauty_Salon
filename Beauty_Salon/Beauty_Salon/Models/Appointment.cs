using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Web.Models;

[Table("appointment")]
public class Appointment
{
    [Key][Column("id")] public int Id { get; set; }

    [Column("client_id")] public int ClientId { get; set; }
    [ForeignKey("ClientId")] public Client? Client { get; set; }

    [Column("master_id")] public int MasterId { get; set; }
    [ForeignKey("MasterId")] public Master? Master { get; set; }

    [Column("service_id")] public int? ServiceId { get; set; }
    [ForeignKey("ServiceId")] public Service? Service { get; set; }

    [Column("appointment_date")] public DateTime AppointmentDate { get; set; }

    [Column("status")][MaxLength(20)] public string Status { get; set; } = "новая";

    [Column("total_price")] public decimal TotalPrice { get; set; }

    [Column("comment")] public string? Comment { get; set; }

    [Column("is_self_booked")] public bool IsSelfBooked { get; set; }

    [Column("discount_applied")] public decimal DiscountApplied { get; set; }

    [Column("discount_reason")][MaxLength(100)] public string? DiscountReason { get; set; }
}