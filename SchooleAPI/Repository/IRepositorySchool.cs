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
        void CreateStudentAsync(Student student);
        void UpdateStudentAsync(Student student);
        void DeleteStudentAsync(int id);

        Task<IEnumerable<Class>> GetClassesAsync();
        Task<Class> GetClassAsync(int id);
        Task <IEnumerable<Student>> GetStudentOfClass(int id);
        void CreateClassAsync(Class clas);
        void UpdateClassAsync(Class clas);
        void DeleteClassAsync(int id);
    }
}
