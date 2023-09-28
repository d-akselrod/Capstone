using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SweatSmart_Service.Database;
using SweatSmart_Service.Models;

namespace SweatSmart_Service.Controllers;

public class UserController : ControllerBase
{
    private readonly SweatSmartDbContext _context;

    public UserController(SweatSmartDbContext context)
    {
        _context = context;
    }

    [HttpPost("/add-user")]
    public IActionResult AddUser()
    {
        var user = new User { Id = 1, Name = "John Doe" };
        _context.Users.Add(user);
        _context.SaveChanges();

        return Ok();
    }

    [HttpGet("/get-user")]
    public IActionResult GetUsers()
    {
        var users = _context.Users.ToList();
        return Ok(users);

    }
}
