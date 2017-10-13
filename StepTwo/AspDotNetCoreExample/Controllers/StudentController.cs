using Microsoft.AspNetCore.Mvc;
using AspDotNetCoreExample.Services.Commands;
using AspDotNetCoreExample.Interface;

namespace AspDotNetCoreExample.Controllers
{
    public class StudentController : Controller
    {
        private IStudentQueries _studentQueries;

        public StudentController(IStudentQueries studentQueries)
        {
            _studentQueries = studentQueries;
        }

        public IActionResult Index()
        {
            var result = _studentQueries.GetStudents();
            return View(result);
        }

        public IActionResult Detail(int studentId)
        {
            var result = _studentQueries.GetStudentById(studentId);
            return View(result);
        }
    }
}