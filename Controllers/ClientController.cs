using CRM.Models;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    ClientService _service;
    public ClientController(ClientService service)
    {
        _service = service;
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Client>> GetAll() =>
        _service.GetAll();
    
    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Client> Get(int id)
    {
        var client = _service.GetById(id);

        if(client == null)
            return NotFound();

        return client;
    }
    
    [HttpGet("nextId/")]
    public ActionResult<int> NextId() =>
        _service.GetNextId();

    // POST action
    [HttpPost]
    public IActionResult Create(Client client)
    {   
        _service.Create(client);
        return CreatedAtAction(nameof(Create), new { id = client.Id }, client);
    }

    [HttpGet("searchNames/{name}")]
    public ActionResult<Object> SearchNames(string name)
    {
        var names = _service.SearchEnNames(name);

        if(names == null)
            return NotFound();

        return Ok(names);
    }

    // PUT action

    // DELETE action
}
