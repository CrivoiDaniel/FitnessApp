using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Domain.Entities.Admin.Subscriptions;

public class SubscriptionGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    [Column("schedule")]
    public string Schedule { get; set; } = string.Empty;

    [MaxLength(50)]
    [Column("color_theme")]
    public string ColorTheme { get; set; } = "#FF1493";

    [Column("display_order")]
    public int DisplayOrder { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    // Relație 1-to-Many
    public ICollection<SubscriptionPlan> Plans { get; set; } = new List<SubscriptionPlan>();
}

