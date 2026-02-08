using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitnessApp.Infrastructure.Data;

namespace FitnessApp.Web.Controllers.Subscriptions;

[ApiController]
[Route("api/subscriptions")]
public class GetAllSubscriptionController : ControllerBase
{
    private readonly AppDBContext _context;

    public GetAllSubscriptionController(AppDBContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> Show()
    {
        var groups = await _context.SubscriptionGroups
                                   .Include(g => g.Plans)
                                   .OrderBy(g => g.DisplayOrder)
                                   .ToListAsync();

        var result = groups.Select(g => new
        {
            g.Id,
            g.Name,
            g.Schedule,
            g.ColorTheme,
            Plans = g.Plans.Select(p => new
            {
                p.Id,
                Title = p.GetDisplayText(),
                p.TotalPrice,
                PricingInfo = p.GetPricingInfo()
            })
        });
        return Ok(result);
    }
}
