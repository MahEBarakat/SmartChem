using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartChem.Data;

namespace SmartChem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartChemController : ControllerBase
    {
        private readonly DataContext _context;

        public SmartChemController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Element>>> GetElement()
        {
            return Ok(await _context.Elements.ToListAsync());

        }
    }
}
