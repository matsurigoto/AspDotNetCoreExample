using AspDotNetCoreExample.ViewModels;
using System;

namespace AspDotNetCoreExample.Services.Commands
{
    public class StudentCommands
    {
        public bool CreateStudent(StudentModel model)
        {
            return true;
        }

        public bool UpdateStudent(StudentModel model)
        {
            return true;
        }

        public bool DeleteStudentById(Guid id)
        {
            return true;
        }
    }
}
