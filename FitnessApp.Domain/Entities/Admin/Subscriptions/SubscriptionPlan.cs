using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Domain.Entities.Admin.Subscriptions;

public abstract class SubscriptionPlan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("group_id")]
    public int GroupId { get; set; }

    [ForeignKey(nameof(GroupId))]
    public SubscriptionGroup Group { get; set; } = null!;

    [Required]
    [Column("total_price", TypeName = "decimal(9,2)")]
    public decimal TotalPrice { get; set; }

    [Required]
    [Column("price_unit", TypeName = "decimal(9,2)")]
    public decimal PriceUnit { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    // Factory Method
    public abstract string GetDisplayText();
    public abstract string GetPricingInfo();
}
