using Microsoft.AspNetCore.Mvc;
using Projeto.API.Models;

namespace Projeto.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
             EventoId = 1,
             Tema = "Angular 11 e .NET 5",
             Local = "GOIAS",
             Lote = "1",
             QtdPessoas = 250,
             DataEvento = DateTime.Now.AddDays(2).ToString(),
             ImageURL = "foto.png"
             },
            new Evento(){
             EventoId = 2,
             Tema = "Angular e Novidades",
             Local = "São Paulo",
             Lote = "2",
             QtdPessoas = 350,
             DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
             ImageURL = "foto1.png"
            }
        };

    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(Evento => Evento.EventoId == id);  
    }

    [HttpPost(Name = "PostEvento")]
    public string Post()
    {
        return "Você fez um POST";
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