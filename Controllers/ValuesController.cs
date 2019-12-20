using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Models;

namespace ProAgil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] {
                new Evento()
                {
                    EventoId  = 10,
                    Tema = "Angular e .NET Core",
                    Local = "Juiz de Fora - MG",
                    Lote = "1° Lote",
                    QtdPessoas = Int32.Parse("250"),
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImgUrl = "LET'S GO!!!"
                    
                },
                
                new Evento()
                {
                    EventoId  = 2,
                    Tema = "Angular e .NET Core",
                    Local = "Juiz de Fora - MG",
                    Lote = "3° Lote",
                    QtdPessoas = Int32.Parse("450"),
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImgUrl = "Vamooos"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] {
                new Evento()
                {
                    EventoId  = 15,
                    Tema = "Angular e .NET Core",
                    Local = "Juiz de Fora - MG",
                    Lote = "3° Lote",
                    QtdPessoas = Int32.Parse("450"),
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImgUrl = "Teste 35"

                },

                new Evento()
                {
                    EventoId  = 20,
                    Tema = "Angular e .NET Core",
                    Local = "Juiz de Fora - MG",
                    Lote = "3° Lote",
                    QtdPessoas = Int32.Parse("450"),
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImgUrl = "blitzkrieg bop"
                }
            }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
