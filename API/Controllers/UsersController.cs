using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Authorize]
public class UsersController : BaseApiController
{
    private readonly DataContext _context;

    
    public UsersController(DataContext context)
    {
        _context = context;
    }
    [AllowAnonymous]
    [HttpGet]
    public async  Task<ActionResult<IEnumerable<AppsUser>>> GetUsersAsync ()
    {
        var users = await _context.Users.ToListAsync();
        return Ok(users) ;
    }
    [Authorize]
    [HttpGet("{id:int}")] // api/v1/users/2
    public async Task<ActionResult<AppsUser>> GetUsersByIdAsync (int id)
    {
        var users = await _context.Users.FindAsync(id);
        if (users==null) return NotFound();
        return users;
    }


    [HttpGet("{name}")] // api/v1/users/2
    public  ActionResult<string> Ready (string name)
    {
        return  $"hola {name}" ;
    }

    
}