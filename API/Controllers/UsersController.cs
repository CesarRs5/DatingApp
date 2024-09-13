using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AppsUser>> GetUsers ()
    {
        var users = _context.Users.ToList();

        return Ok(users) ;
    }

    [HttpGet("{id}")] // api/v1/users/2
    public ActionResult<AppsUser> GetUsersById (int id)
    {
        var users = _context.Users.Find(id);
        if (users==null) return NotFound();
        return users;
    }

    
}