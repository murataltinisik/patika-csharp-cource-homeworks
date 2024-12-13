using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Models.Contexts;
using Survivor.Models.DTOs;

namespace Survivor.Controllers.Competitor;

[ApiController]
[Route("api/[controller]")]
public class CompetitorsController : ControllerBase, IController<CompetitorDto>
{
    private readonly DatabaseContext _context;
    
    public CompetitorsController(DatabaseContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _context.Competitors.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        // Get Data
        var competitor = await _context.Competitors.SingleOrDefaultAsync(c => c.Id == id);
        
        // Is Not Found
        if(competitor is null) return NotFound();
        
        // Return Ok
        return Ok(competitor);
    }
    
    [HttpGet("categories/{id}")]
    public async Task<IActionResult> GetAllByCategoryId(int id)
    {
        return Ok(await _context.Competitors.Where(c => c.CategoryId == id).ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Post(CompetitorDto t)
    {
        // Is valid
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
    
            return BadRequest(new { Message = "Validation failed. First error encountered.", Errors = errors });
        }
        
        // Add data to DbSet
        Models.Entities.Competitor competitor = new()
        {
            FirstName = t.FirstName,
            LastName = t.LastName,
            CategoryId = t.CategoryId
        };
        
        _context.Competitors.Add(competitor);
        
        // Save Changes
        await _context.SaveChangesAsync();
        
        // Return
        return CreatedAtAction(nameof(GetById), new { id = t.Id }, t);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        // Get Data
        var competitor = await _context.Competitors.SingleOrDefaultAsync(c => c.Id == id);
        
        // Is Not Found
        if(competitor is null) return NotFound();
        
        // Update Item -> IsDeleted Property
        competitor.IsDeleted = true;
        _context.Update(competitor);
        
        // Save Changes
        await _context.SaveChangesAsync();
        
        // Return No Content
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(CompetitorDto t, int id)
    {
        // Get Data
        var competitor = await _context.Competitors.SingleOrDefaultAsync(c => c.Id == id);
        
        // Is Not Found
        if(competitor is null) return NotFound();

        // Update Item
        competitor.FirstName = t.FirstName;
        competitor.LastName = t.LastName;
        competitor.CategoryId = t.CategoryId;
        _context.Update(competitor);
        
        // Save Changes
        await _context.SaveChangesAsync();
        
        // Return 
        return CreatedAtAction(nameof(GetById), new { id = t.Id }, t);
    }
}