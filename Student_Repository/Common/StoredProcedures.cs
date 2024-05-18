namespace Student_Repository.Common
{
    public class StoredProcedures
    {
        public const string GetAllStudents = "dbo.sp_GetAllStudents";
        public const string GetStudentById = "dbo.sp_GetStudentById";
        public const string AddStudent = "dbo.sp_AddStudent";
        public const string UpdateStudent = "dbo.sp_UpdateStudent";
        public const string DeleteStudent = "sp_DeleteStudent";
    }
}
