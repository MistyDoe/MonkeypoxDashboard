using DashBoardAPI.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace DashBoardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {

        private readonly CaseContext _context;

        public CaseController (CaseContext context)
        {
            _context = context;
        }

        // GET: Case
        [HttpGet("{country}")]
        public async Task<IActionResult> CasesCountry (string country)
        {
            if ( country == null || _context.Cases == null )
            {
                return NotFound();
            }
            var cases = await _context.Cases
                .Where(l => l.location == country)
                .ToListAsync();

            return cases != null ?
                Ok(CasesForCnty(cases)) :
                Problem("no cases");
        }

        // GET: Case/Details/5
        [HttpGet]
        public async Task<IActionResult> CountryList ( )
        {
            var countryList = await _context.Cases
                .Select(l => l.location)
                .Distinct()
                .ToListAsync();
            return countryList != null ?
                Ok(countryList) :
                Problem("No country found");
        }
    }
}
