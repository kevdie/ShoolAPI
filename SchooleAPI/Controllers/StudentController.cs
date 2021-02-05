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
    public class StudentController : ControllerBase
    {
        private IRepositorySchool repository;

        public StudentController(IRepositorySchool repository)
        {
            this.repository= repository;
        }
        // GET api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var students = await repository.GetStudentsAsync();
            return Ok(students);
        }

        // GET api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id )
        {
            var students = await repository.GetStudentAsync(id);
            return Ok(students);
        }

        // POST api/Student
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent([FromBody] Student student)
        {
            var students= await repository.CreateStudentAsync(student);
            return Ok(students); 

        }

        // PUT api/Student/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> PutStudent(int id, [FromBody] Student student)
        {
           return Ok( await repository.UpdateStudentAsync(id,student));
             
        }

        // DELETE api/Student/5
        [HttpDelete("{id}")]
        public void DeleteStudent(int id)
        {
            repository.DeleteStudentAsync(id);
        }
    }
}
