using FitnessApp.Domain.Entities.Admin.Subscriptions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Infrastructure.Data;

public class AppDBContext : IdentityDbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

    public DbSet<SubscriptionGroup> SubscriptionGroups { get; set; }
    
    // Aceasta este baza. EF Core are nevoie să vadă și derivatele.
    public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
    
    // Adăugăm DbSets și pentru clasele concrete (ajută la rezolvarea erorii)
    public DbSet<MonthlyPlan> MonthlyPlans { get; set; }
    public DbSet<SessionPlan> SessionPlans { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // CONFIGURAREA PENTRU FACTORY METHOD (Inheritance)
        modelBuilder.Entity<SubscriptionPlan>()
            .HasDiscriminator<string>("plan_type") // Numele coloanei automate din MySQL
            .HasValue<MonthlyPlan>("monthly")      // Dacă în coloană scrie "monthly" -> creează MonthlyPlan
            .HasValue<SessionPlan>("session");    // Dacă scrie "session" -> creează SessionPlan
            
        // Opțional: Forțăm numele tabelelor la plural
        modelBuilder.Entity<SubscriptionGroup>().ToTable("subscription_groups");
        modelBuilder.Entity<SubscriptionPlan>().ToTable("subscription_plans");
    }
}