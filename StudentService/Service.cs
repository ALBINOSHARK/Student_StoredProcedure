using Core.Interface;
using Core.Models;
using System.Collections;

namespace StudentService
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _repository.GetAllStudents();
        }

        public Task<Student> GetStudentById(int id)
        {
            return _repository.GetStudentById(id);
        }

        public Task<Student> AddStudent(Student student)
        {
            return _repository.AddStudent(student); 
        }

        public Task<Student> UpdateStudent(Student student)
        {
            return _repository.UpdateStudent(student);
        }
        public Task<bool> DeleteStudent(int id)
        {
            return _repository.DeleteStudent(id);
        }

    }
}
