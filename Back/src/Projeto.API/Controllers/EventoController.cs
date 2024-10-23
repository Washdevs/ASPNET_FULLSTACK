using Microsoft.AspNetCore.Mvc;

namespace Projeto.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
    }

    [HttpGet(Name = "GetEvento")]
    public string Get()
    {
        return "Exemplo GET";
    }

    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
        return "Exemplo POST";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo PUT com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo PUT com Delete = {id}";
    }
}