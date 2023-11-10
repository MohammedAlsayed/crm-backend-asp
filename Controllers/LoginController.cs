using CRM.Models;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    public LoginController()
    {
    }

    [HttpGet("{username}/{password}")]
    public ActionResult<bool> Get(string userName, string password)
    {
        var user = UserService.Get(userName, password);

        if(user == null)
            return NotFound();

        return true;
    }
    
    // GET all action

    // GET by Id action

    // POST action

    // PUT action

    // DELETE action
}