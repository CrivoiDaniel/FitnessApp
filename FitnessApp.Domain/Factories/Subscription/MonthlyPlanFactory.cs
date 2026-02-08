using FitnessApp.Domain.Entities.Admin.Subscriptions;

namespace FitnessApp.Domain.Factories.Subscription;

public class MonthlyPlanFactory : PlanFactory
{
    private readonly int months;
    private readonly decimal totalPrice;
    private readonly int groupId;

    public MonthlyPlanFactory(int months, decimal totalPrice, int groupId)
    {
        this.months = months;
        this.totalPrice = totalPrice;
        this.groupId = groupId;
    }

    public override SubscriptionPlan CreatePlan()
    {
        return new MonthlyPlan
        {
            GroupId = this.groupId,
            DurationMonths = this.months,
            TotalPrice = this.totalPrice,
            PriceUnit = this.totalPrice / this.months
        };
    }
}