using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchooleAPI.Models;
using SchooleAPI.Repository;

namespace SchooleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private IRepositorySchool repository;

        public ClassController(IRepositorySchool repository)
        {
            this.repository = repository;
        }
        // GET api/Classs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasss()
        {
            var Classs = await repository.GetClassesAsync();
            return Ok(Classs);
        }

        // GET api/Class/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            var Classs = await repository.GetClassAsync(id);
            return Ok(Classs);
        }

        // POST api/Class
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass([FromBody] Class Class)
        {
            var Classs = await repository.CreateClassAsync(Class);
            return Ok(Classs);

        }

        // PUT api/Class/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Class>> PutClass(int id, [FromBody] Class Class)
        {
            return Ok(await repository.UpdateClassAsync(id, Class));

        }

        // DELETE api/Class/5
        [HttpDelete("{id}")]
        public void DeleteClass(int id)
        {
            repository.DeleteClassAsync(id);
        }
    }
}
