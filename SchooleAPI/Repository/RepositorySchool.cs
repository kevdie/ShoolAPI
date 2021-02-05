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
            return await Task.FromResult(students);
        }
        public async Task<Student> GetStudentAsync(int id)
        {
            return await Task.FromResult(students.Find(x => x.IdStudent==id));
        }
        public async Task<IEnumerable<Class>> GetClassOfStudentAsync(int id)
        {
            return await Task.FromResult((students.Find(x => x.IdStudent == id)).classes);
        }
        public async Task<Student> CreateStudentAsync(Student student)
        {
            students.Add(student);
            return await Task.FromResult(student);
        }
        public async Task<Student> UpdateStudentAsync(int id, Student student)
        {
            var stud=students.FirstOrDefault(x => x.IdStudent == id);
            stud.FirstName = student.FirstName ?? stud.FirstName;
            stud.LastName = student.LastName ?? stud.LastName;
            return await Task.FromResult(stud);

        }
        public async Task<Student> DeleteStudentAsync(int id)
        {
            var stud =  students.FirstOrDefault(x => x.IdStudent == id);
            students.RemoveAll(x => x.IdStudent == id);
            return await Task.FromResult(stud);
        }

        public async Task<IEnumerable<Class>> GetClassesAsync()
        {
            return await Task.FromResult(classes);
        }
        public async Task<Class> GetClassAsync(int id)
        {
            return await Task.FromResult(classes.Find(x => x.IdClass == id));
        }

        public async Task<IEnumerable<Student>> GetStudentOfClass(int id)
        {
            return await Task.FromResult((classes.Find(x => x.IdClass == id)).students);
        }
        public async Task<Class> CreateClassAsync(Class clas)
        {
            classes.Add(clas);
            return await Task.FromResult(clas);
        }
        public async Task<Class> UpdateClassAsync(int id, Class clas)
        {
            var clase = classes.FirstOrDefault(x => x.IdClass == id);
            clase.Title = clas.Title ?? clase.Title;
            clase.Description = clas.Description ?? clase.Description;
            return await Task.FromResult(clase);

        }
        public void DeleteClassAsync(int id)
        {
            classes.RemoveAll(x => x.IdClass == id);
        }
    }
}
