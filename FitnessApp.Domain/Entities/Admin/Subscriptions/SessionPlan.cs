using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Domain.Entities.Admin.Subscriptions;

public class SessionPlan : SubscriptionPlan
{
   [Required]
   [Column("session_count")]
   public int SessionCount { get; set; }
   public override string GetDisplayText()
   {
      return $"{SessionCount} {(SessionCount == 1 ? "session" : "sessions")} to gym";
   }

   public override string GetPricingInfo()
   {
      return $"{PriceUnit:N0} mdl/session";
   }
}
