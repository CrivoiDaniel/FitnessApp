using FitnessApp.Domain.Entities.Admin.Subscriptions;

namespace FitnessApp.Domain.Factories.Subscription;

public class SessionPlanFactory : PlanFactory
{
    private readonly int sessions;
    private readonly decimal totalPrice;
    private readonly int groupId;

    public SessionPlanFactory(int sessions, decimal totalPrice, int groupId)
    {
        this.sessions = sessions;
        this.totalPrice = totalPrice;
        this.groupId = groupId;
    }

    public override SubscriptionPlan CreatePlan()
    {
        return new SessionPlan
        {
            GroupId = this.groupId,
            SessionCount = this.sessions,
            TotalPrice = this.totalPrice,
            PriceUnit = this.totalPrice / this.sessions
        };
    }
}