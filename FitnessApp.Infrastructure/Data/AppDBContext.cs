using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Infrastructure.Data;

public class AppDBContext : IdentityDbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {}

    

}
