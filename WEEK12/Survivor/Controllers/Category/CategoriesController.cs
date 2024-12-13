using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Models.Contexts;
using Survivor.Models.DTOs;

namespace Survivor.Controllers.Category;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase, IController<CategoryDto>
{
    // Context
    private readonly DatabaseContext _context;

    public CategoriesController(DatabaseContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _context.Categories.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        // Get Data
        var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
        
        // Is Not Found
        if(category is null) return NotFound();
        
        // Return Ok
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CategoryDto t)
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
        Models.Entities.Category category = new Models.Entities.Category
        {
            Name = t.Name,
        };
        
        _context.Categories.Add(category);
        
        // Save Changes
        await _context.SaveChangesAsync();
        
        // Return
        return CreatedAtAction(nameof(GetById), new { id = t.Id }, t);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        // Get Data
        var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
        
        // Is Not Found
        if(category is null) return NotFound();
        
        // Update Item -> IsDeleted Property
        category.IsDeleted = true;
        _context.Update(category);
        
        // Save Changes
        await _context.SaveChangesAsync();
        
        // Return No Content
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromBody] CategoryDto t, int id)
    {
        // Get Data
        var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
        
        // Is Not Found
        if(category is null) return NotFound();

        // Update Item
        category.Name = t.Name;
        _context.Update(category);
        
        // Save Changes
        await _context.SaveChangesAsync();
        
        // Return 
        return CreatedAtAction(nameof(GetById), new { id = t.Id }, t);
    }
}