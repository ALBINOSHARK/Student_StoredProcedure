using Core.Interface;
using Core.Models;
using Student_Repository.Common;
using System.Data;
using Dapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Student_Repository
{
    public class Repository : IRepository
    {
        private readonly Helper _helper;

        public Repository(Helper helper)
        {
            _helper = helper;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            using (var connection = this._helper.CreateConnection())
            {
                var stu = await connection.QueryAsync<Student>
                    (StoredProcedures.GetAllStudents, commandType: CommandType.StoredProcedure);
                return stu;

            }
        }

        public async Task<Student> GetStudentById(int id)
        {

            var parameters = new DynamicParameters();
            var procedureName = StoredProcedures.GetStudentById;
            parameters.Add("@StudentId", id, DbType.Int32, ParameterDirection.Input);

            using (var connection = _helper.CreateConnection())
            {
                var student = await connection.QueryFirstOrDefaultAsync<Student>(
                    procedureName, parameters, commandType: CommandType.StoredProcedure);

                return student;
            }
        }
        public async Task<Student> AddStudent(Student student)
        {
            var parameters = new DynamicParameters();
            var procedureName = StoredProcedures.AddStudent;
            parameters.Add("@Name", student.Name, DbType.String, ParameterDirection.Input);
            parameters.Add("@Age", student.Age, DbType.Int64, ParameterDirection.Input);
            parameters.Add("@RollNo", student.RollNo, DbType.String, ParameterDirection.Input);
            parameters.Add("@Address", student.Address, DbType.String, ParameterDirection.Input);
            using (var connection = this._helper.CreateConnection())
            {
                var stu = await connection.QueryFirstOrDefaultAsync<Student>(
                    procedureName, parameters, commandType: CommandType.StoredProcedure);
                return stu;
            }
        }
        public async Task<Student> UpdateStudent(Student student)
        {
            var parameters = new DynamicParameters();
            var procedureName = StoredProcedures.UpdateStudent;
            parameters.Add("@StudentId", student.Id, DbType.Int32, ParameterDirection.Input);
            parameters.Add("@Name", student.Name, DbType.String, ParameterDirection.Input);
            parameters.Add("@Age", student.Age, DbType.Int64, ParameterDirection.Input);
            parameters.Add("@RollNo", student.RollNo, DbType.String, ParameterDirection.Input);
            parameters.Add("@Address", student.Address, DbType.String, ParameterDirection.Input);
            using (var connection = this._helper.CreateConnection())
            {
                var stu = await connection.QueryFirstOrDefaultAsync<Student>(
                    procedureName, parameters, commandType: CommandType.StoredProcedure);
                return stu;
            }
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var parameters = new DynamicParameters();
            var procedureName = StoredProcedures.DeleteStudent;
            parameters.Add("@StudentId", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _helper.CreateConnection())
            {
                var rowsAffected = await connection.ExecuteAsync(
                    procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
