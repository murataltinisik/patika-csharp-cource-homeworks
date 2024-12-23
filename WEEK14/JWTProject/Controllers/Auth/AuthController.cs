using JWTProject.Helpers;
using JWTProject.Models.Contexts;
using JWTProject.Models.DTOs;
using JWTProject.Models.Entities;
using JWTProject.Validations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace JWTProject.Controllers.Auth;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly DatabaseContext _context;
    private readonly IDataProtector _protector;
    private readonly IConfiguration _configuration;

    public AuthController(IDataProtectionProvider protector, DatabaseContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
        _protector = protector.CreateProtector("UserPasswordProtection");
    }

    [HttpPost("login")]
    public IActionResult Login(UserDto userDto)
    {
        // Create Validator
        var validator = new UserLoginValidation(_context);
        
        // Validation
        var validationResult = validator.Validate(userDto);
        
        // Return error
        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors
                .Select(x => x.ErrorMessage);
            
            return BadRequest(new { Errors = errors });
        }
        
        // Get User
        var user = _context.Users.SingleOrDefault(u => u.Email == userDto.Email);
        
        // Check Password
        if (_protector.Unprotect(user.Password) != userDto.Password){
            return BadRequest(new { Error = "Wrong Password" });
        }
        
        // Create Token
        var token = JwtHelper.GenerateToken(userDto.Email, _configuration);

        // Ok
        return Ok(new { Message = "Login successfully!", Token = token });
    }
    
    [HttpPost("register")]
    public IActionResult Register(UserDto userDto)
    {
        // Create Validator
        var validator = new UserRegisterValidator(_context);
        
        // Validation
        var validationResult = validator.Validate(userDto);
        
        // Return Error
        if (!validationResult.IsValid)
        {
            var errors = validationResult.Errors
                .Select(x => x.ErrorMessage);
            
            return BadRequest(new { Errors = errors });
        }
        
        // Create Instance User
        User user = new()
        {
            Email = userDto.Email,
            Password = _protector.Protect(userDto.Password)
        };
        
        // Add to DbSet
        _context.Users.Add(user);
        
        // Save Changes
        _context.SaveChanges();
        
        // Create Token
        var token = JwtHelper.GenerateToken(userDto.Email, _configuration);
        
        return Ok(new { Message = "User registered successfully!", Token = token });
    }
}