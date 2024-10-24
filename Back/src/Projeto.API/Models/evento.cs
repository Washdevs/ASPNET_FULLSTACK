using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Projeto.API.Models
{
    public class Evento
    {
    public int MyProperty { get; set; }
    public int EventoId { get; set; }
    public string? Local { get; set; }
    public string? DataEvento { get; set; }
    public string? Tema { get; set; }
    public int QtdPessoas { get; set; }
    public string? Lote { get; set; }
    public string? ImageURL { get; set; }    
    }
}