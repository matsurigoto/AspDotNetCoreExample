using AspDotNetCoreExample.Interface;
using AspDotNetCoreExample.ViewModels;
using System;
using System.Collections.Generic;

namespace AspDotNetCoreExample.Services.Commands
{
    public class StudentQueries : IStudentQueries
    {
        public StudentModel GetStudentById(int studentId)
        {
            return new StudentModel
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = "Duran"
            };
        }

        public List<StudentModel> GetStudents()
        {
            List<StudentModel> list = new List<StudentModel>();
            list.Add(new StudentModel
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = "Duran"
            });

            list.Add(new StudentModel
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = "Sky"
            });

            list.Add(new StudentModel
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = "Kyle"
            });

            return list;
        }
    }
}
