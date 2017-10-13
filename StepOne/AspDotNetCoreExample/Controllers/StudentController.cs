using Microsoft.AspNetCore.Mvc;
using AspDotNetCoreExample.Services.Commands;

namespace AspDotNetCoreExample.Controllers
{
    public class StudentController : Controller
    {
        public StudentQueries query = new StudentQueries();

        public IActionResult Index()
        {
            var result = query.getStudents();
            return View(result);
        }

        public IActionResult Detail(int studentId)
        {
            var result = query.getStudentById(studentId);
            return View(result);
        }
    }
}