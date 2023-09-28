using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EventoController : ControllerBase
    {
    

         public EventoController()
        {
        
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[] {
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(1).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "2º Lote",
                    QtdPessoas = 500,
                    DataEvento = DateTime.Now.AddDays(7).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 3,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "3º Lote",
                    QtdPessoas = 750,
                    DataEvento = DateTime.Now.AddDays(14).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 4,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "4º Lote",
                    QtdPessoas = 1000,
                    DataEvento = DateTime.Now.AddDays(21).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 5,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "5º Lote",
                    QtdPessoas = 1250,
                    DataEvento = DateTime.Now.AddDays(28).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 6,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "6º Lote",
                    QtdPessoas = 1500,
                    DataEvento = DateTime.Now.AddDays(35).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 7,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "7º Lote",
                    QtdPessoas = 1750,
                    DataEvento = DateTime.Now.AddDays(42).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "8º Lote",
                    QtdPessoas = 2000,
                    DataEvento = DateTime.Now.AddDays(49).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 8,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "9º Lote",
                    QtdPessoas = 2250,
                    DataEvento = DateTime.Now.AddDays(56).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 9,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "10º Lote",
                    QtdPessoas = 2500,
                    DataEvento = DateTime.Now.AddDays(63).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                new Evento(){
                    EventoId = 10,
                    Tema = "Angular e ASP.NET Core Web API, Entity Framework Core e ASP.NET Core Identity",
                    Local = "Cotia/SP",
                    Lote = "11º Lote",
                    QtdPessoas = 2750,
                    DataEvento = DateTime.Now.AddDays(70).ToString("yyyy/mm/dd"),
                    ImageURL = "https://fastly.picsum.photos/id/866/200/300.jpg?hmac=rcadCENKh4rD6MAp6V_ma-AyWv641M4iiOpe1RyFHeI"
                },
                
            };
            
        }

        [HttpPost]
        public string Post()
        {
            return "GOMU GOMU NO: gatling gun POST";

        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"GOMU GOMU NO: red hawk {id}";

        }
        [HttpDelete("{id}")]
        public string Delete( int id)
        {
            return $"GOMU GOMU NO: bount man{id}";
        }
    }
}
