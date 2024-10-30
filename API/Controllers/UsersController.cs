namespace API.Controllers;
using API.Data;
using API.DataEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



[Authorize]
public class UsersController : BaseApiController
{
    private readonly IUserRepository _repository;

    public UsersController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppsUser>>> GetAllAsync()
    {
        var users = await _repository.GetAllAsync();
        return Ok(users);
    }

    [HttpGet("{id:int}")] // api/v1/users/2
    public async Task<ActionResult<AppsUser>> GetByIdAsync(int id)
    {
        var users = await _repository.GetByIdAsync(id);
        if (users == null)
        {
            return NotFound();
        }

        return users;
    }


    [HttpGet("{username}")] // api/v1/users/2
    public async Task<ActionResult<AppsUser>> GetByUsernameAsync(string username)
    {
        var users = await _repository.GetByUsernameAsync(username);
        if (users == null)
        {
            return NotFound();
        }

        return users;
    }


}