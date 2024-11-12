using DemoMVCFW.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DemoMVCFW.Controllers
{
    public class StudentController : Controller

    {

        private readonly IStudent _studentSerivce;
        private readonly DummyClass _dummyClass;

        public StudentController(IStudent studentImpl , DummyClass dummyClass)
        {
            _studentSerivce =  studentImpl;
            _dummyClass = dummyClass;
        }

        public IActionResult Index()
        {
            var students = _studentSerivce.DataSource();
           
            return View(students);
        }

        public IActionResult Details(int id) {

            

            var student = _studentSerivce.GetStudent(id);
            _dummyClass.DummyGetStudents(id);
            if (student == null)
            {
                TempData["ErrorMessage"] = "Student not found.";
                return RedirectToAction("Index");
            }

            return View(student);


           }

        public IActionResult Result()
        {
            var students = _studentSerivce.DataSource();

            return View(students);
           

        }



    }
}
