using Core.Interface;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_StoredProcedure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IService _service;
        public StudentController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var stu = await _service.GetAllStudents();
            return Ok(stu);
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var stu = await _service.AddStudent(student);
            return Ok(stu);
        }
        [HttpGet]
        [Route("Get By Id/{Id}")]
        public async Task<IActionResult> GetStudentById(int Id)
        {
            var stu = await _service.GetStudentById(Id);
            return Ok(stu);
        }
        [HttpPut]
        public Task<Student> UpdateStudent(Student student)
        {
            var stu =_service.UpdateStudent(student);
            return stu;
        }
        [HttpDelete]
        public Task<bool> DeleteStudent(int id)
        {
            return _service.DeleteStudent(id);
        }

    }
}