using Core.Models;

namespace Core.Interface
{
    public interface IService
    {
        public Task<IEnumerable<Student>> GetAllStudents();
        public Task<Student> GetStudentById(int id);
        public Task<Student> AddStudent(Student student);
        public Task<Student> UpdateStudent(Student student);
        public Task<bool> DeleteStudent(int id);
    }
}
