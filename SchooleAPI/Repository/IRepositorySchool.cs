using SchooleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchooleAPI.Repository
{
    public interface IRepositorySchool
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(int id);
        Task<IEnumerable<Class>> GetClassOfStudentAsync(int id);
        Task<Student> CreateStudentAsync(Student student);
        Task<Student> UpdateStudentAsync(int id, Student student);
        Task<Student> DeleteStudentAsync(int id);

        Task<IEnumerable<Class>> GetClassesAsync();
        Task<Class> GetClassAsync(int id);
        Task <IEnumerable<Student>> GetStudentOfClass(int id);
        Task<Class> CreateClassAsync(Class clas);
        Task<Class> UpdateClassAsync(int id, Class clas);
        void DeleteClassAsync(int id);
    }
}
