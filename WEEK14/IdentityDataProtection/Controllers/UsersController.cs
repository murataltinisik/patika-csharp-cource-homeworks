using IdentityDataProtection.Models.Context;
using IdentityDataProtection.Models.Entities;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDataProtection.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly DatabaseContext _context;
    private readonly IDataProtector _dataProtector;

    public UsersController(IDataProtectionProvider provider, DatabaseContext context)
    {
        _context = context;
        _dataProtector = provider.CreateProtector("UserPasswordProtection");
    }
    
    [HttpPost]
    public IActionResult Save(User user)
    {
        // Model is valid
        if (!ModelState.IsValid)
        {
            var error = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);
            
            // Return Error
            return BadRequest(error);
        }
        
        // User Password Protect
        user.Password = _dataProtector.Protect(user.Password);
        
        // Add User to Database
        _context.Users.Add(user);
        
        // Save Changes
        _context.SaveChanges();
        
        // return 
        return Ok(new { Message = "User added successfully!", User = user });
    }
}