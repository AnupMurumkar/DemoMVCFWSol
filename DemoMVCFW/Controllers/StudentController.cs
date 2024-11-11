using DemoMVCFW.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DemoMVCFW.Controllers
{
    public class StudentController : Controller

    {

        private readonly IStudent _studentSerivce;

        public StudentController()
        {
            _studentSerivce = new studentImpl();
        }

        public IActionResult Index()
        {
            var students = _studentSerivce.DataSource();
           
            return View(students);
        }

        public IActionResult Details(int id) {

            var student = _studentSerivce.GetStudent(id);
            if (student == null)
            {
                TempData["ErrorMessage"] = "Student not found.";
                return RedirectToAction("Index");
            }

            return View(student);


           }


        
    }
}
