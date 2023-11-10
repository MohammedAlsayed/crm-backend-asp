using CRM.Models;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    public ClientController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Client>> GetAll() =>
        ClientService.GetAll();
    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Client> Get(int id)
    {
        var client = ClientService.Get(id);

        if(client == null)
            return NotFound();

        return client;
    }
    
    [HttpGet("nextId/")]
    public ActionResult<int> NextId() =>
        ClientService.GetNextId();

    // POST action
    [HttpPost]
    public IActionResult Create(Client client)
    {
        // write to console client object
        Console.WriteLine(client);
        
        ClientService.Add(client);
        return CreatedAtAction(nameof(Create), new { id = client.Id }, client);
    }

    [HttpGet("searchIds/{name}")]
    public ActionResult<List<string>> SearchIds(string name)
    {
        var names = ClientService.SearchEnNames(name);

        if(names == null)
            return NotFound();

        return names;
    }

    // PUT action

    // DELETE action
}
