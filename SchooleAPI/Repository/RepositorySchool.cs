using SchooleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchooleAPI.Repository
{
    public class RepositorySchool : IRepositorySchool
    {
        private List<Student> students = new List<Student>();
        private List<Class> classes = new List<Class>();

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {

        }
        public async Task<Student> GetStudentAsync(int id)
        {

        }
        public async Task<Class> GetClassOfStudentAsync(int id)
        {

        }
        public void CreateStudentAsync(Student student)
        {

        }
        public void UpdateStudentAsync(Student student)
        {

        }
        public void DeleteStudentAsync(int id)
        {

        }

        public async Task<IEnumerable<Class>> GetClassesAsync()
        {

        }
        public async Task<Class> GetClassAsync(int id)
        {

        }

        public async Task<Student> GetStudentOfClass(int id)
        {

        }
        public void CreateClassAsync(Student student)
        {

        }
        public void UpdateClassAsync(Student student)
        {

        }
        public void DeleteClassAsync(int id)
        {

        }
    }
}
