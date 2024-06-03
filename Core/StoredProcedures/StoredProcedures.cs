using Azure;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Core.StoredProcedures
{
    public class StoredProcedures
    {
        // ALTER PROCEDURE[dbo].[sp_GetAllStudents]
        // AS
        // BEGIN
        //SELECT* FROM Student;
        // END;


        // ALTER PROCEDURE[dbo].[sp_GetStudentById]
        // @StudentId INT
        // AS
        // BEGIN
        //SELECT* FROM Student WHERE Id = @StudentId;
        //END;



        //   ALTER PROCEDURE[dbo].[sp_AddStudent]
        //   @Name Varchar(100),
        //@Age int,
        //   @RollNo Varchar(20),
        //   @Address Varchar(255)
        //   AS
        //   BEGIN
        // INSERT INTO Student(Name, Age, RollNo, Address)
        //  VALUES(@Name, @Age, @RollNo, @Address);
        //   END;


        // ALTER PROCEDURE[dbo].[sp_UpdateStudent]
        // @StudentId INT,
        //   @Name Varchar(100),
        //@Age int,
        //  @RollNo Varchar(20),
        //  @Address Varchar(255) 
        //  AS
        // BEGIN
        //UPDATE Student
        //SET Name = @Name, @Age = Age, RollNo = @RollNo, Address = @Address
        //WHERE Id = @StudentId;
        //END;


        //ALTER PROCEDURE[dbo].[sp_DeleteStudent]
        //@StudentId INT
        //AS
        //BEGIN
        //DELETE FROM Student
        //WHERE Id = @StudentId;
        //END;
    }
}
