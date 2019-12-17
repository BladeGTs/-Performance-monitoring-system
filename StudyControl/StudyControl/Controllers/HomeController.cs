using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudyControl.Data;
using StudyControl.Models;

namespace StudyControl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<string> Test()
        {
            var student = new Student() { FirstName = "fn", LastName = "ln" };
            var course = new Course() { Name = "Математика" };

            student.StudentCourses = new List<StudentCourse>();
            student.StudentCourses.Add(new StudentCourse() { Student = student, Course = course });

            await _dbContext.AddAsync(course);
            await _dbContext.AddAsync(student);

            await _dbContext.SaveChangesAsync();

            return "hello";
        }

        public string GetStudentCourses(int id)
        {
            _dbContext.Students.
            
            var student = _dbContext.Students
                .Include(r => r.StudentCourses)
                .FirstOrDefault(s => s.Id == id)
                .;


            var s = _dbContext.Students.FromSql("select *"
+ " from Students as s"
+ " left join StudentCourses as sc on s.Id = sc.StudentId"
+ " left join Courses as c on sc.CourseId"
+ " where s.Id = " + id);

                //.Where(s => s.Id == id).Include(s => s.StudentCourses).ThenInclude(s => s.)

            //var student = _dbContext.Students.Where(r => r.Id == id).ToList();
            if (student == null)
            {
                return "нет студента";
            }

            var course = student.StudentCourses.First().Course.Name;
            return course;
        }
    }
}
