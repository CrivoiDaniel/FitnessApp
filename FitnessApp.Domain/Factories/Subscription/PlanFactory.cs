using FitnessApp.Domain.Entities.Admin.Subscriptions;

namespace FitnessApp.Domain.Factories.Subscription;

public abstract class PlanFactory
{
    public abstract SubscriptionPlan CreatePlan();
}