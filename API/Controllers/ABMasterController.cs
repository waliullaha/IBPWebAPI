using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ABMasterController : ControllerBase
    {
        private readonly AHS_IBPContext _context;
        public ABMasterController(AHS_IBPContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Abmaster>>> GetABs() 
        {
            var abs= await _context.Abmasters.ToListAsync();

            return Ok(abs);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Abmaster>> GetAB(int id) 
        {
            return await _context.Abmasters.FindAsync(id);
        }
    }
}