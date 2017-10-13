using AspDotNetCoreExample.ViewModels;
using System;

namespace AspDotNetCoreExample.Interface
{
    public interface IStudentCommands
    {
        bool CreateStudent(StudentModel model);

        bool UpdateStudent(StudentModel model);

        bool DeleteStudentById(Guid id);
    }
}
