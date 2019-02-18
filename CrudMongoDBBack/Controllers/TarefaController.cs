using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMongoDB.Models;
using CrudMongoDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudMongoDB.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly TarefaService _tarefaService;

        public TarefaController(TarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        // GET api/values
        [HttpGet("tarefas")]
        public ActionResult<IEnumerable<Tarefa>> Get()
        {
            return OK(_tarefaService.Get());
        }

        // GET api/values/5
        [HttpGet("tarefas/{id}")]
        public ActionResult<Tarefa> Get(int id)
        {
            if (String.IsNullOrEmpty(id)) 
            {
                return NoContent();
            }
            return OK(_tarefaService.Get(id);
        }

        // POST api/values
        [HttpPost("tarefas/{tarefa}")]
        public void Post([FromBody] Tarefa tarefa)
        {
            _tarefaService.Create(tarefa);
        }

        // PUT api/values/5
        [HttpPut("tarefas/{id}/{tarefa}")]
        public void Put(int id, [FromBody] Tarefa tarefa)
        {
            _tarefaService.Update(id, tarefa);
        }

        // DELETE api/values/5
        [HttpDelete("tarefas/{id}")]
        public void Delete(int id)
        {
            _tarefaService.Remove(id);
        }
    }
}
