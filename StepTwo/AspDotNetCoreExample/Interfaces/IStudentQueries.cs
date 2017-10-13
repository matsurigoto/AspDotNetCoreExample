using AspDotNetCoreExample.ViewModels;
using System.Collections.Generic;

namespace AspDotNetCoreExample.Interface
{
    public interface IStudentQueries
    {
        StudentModel GetStudentById(int studentId);

        List<StudentModel> GetStudents();
    }
}
