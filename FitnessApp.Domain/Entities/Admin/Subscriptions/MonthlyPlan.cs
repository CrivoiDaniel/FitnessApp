using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Domain.Entities.Admin.Subscriptions;

public class MonthlyPlan : SubscriptionPlan
{
    [Required]
    [Range(1, 12)]      
    [Column("duration_months")]
    public int DurationMonths { get; set; }
    public override string GetDisplayText()
    {
        return $"{DurationMonths} {(DurationMonths == 1 ? "month" : "months")}";
    }


    public override string GetPricingInfo()
    {
       return $"{PriceUnit:NO} mdl/month";
    }
}
