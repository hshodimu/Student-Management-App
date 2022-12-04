using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class CourseController : Controller
    {
        public readonly ApplicationDbContext _db;

        public CourseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Course> objList = _db.Courses;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCoursesViewModel addCoursesRequest)
        {

           var course = new Course()
            {
                CourseId = addCoursesRequest.CourseId,
                Name = addCoursesRequest.Name,
                GradeId = addCoursesRequest.GradeId,

            };

            await _db.AddAsync(course);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int RecordNum)
        {

            var course = await _db.Courses.FirstOrDefaultAsync(x => x.RecordNum == RecordNum);

            if (course != null) 
            {
                var viewModel = new Course()
                {
                    CourseId = course.CourseId,
                    Name = course.Name,
                    GradeId = course.GradeId,

                };

                return await Task.Run(() => View("Update", viewModel));
            }

             return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Course updateCourseReqeust)
        {

            var course = await _db.Courses.FindAsync(updateCourseReqeust.RecordNum);

            if (course != null)
            {
                course.CourseId = updateCourseReqeust.CourseId;
                course.Name = updateCourseReqeust.Name;
                course.GradeId = updateCourseReqeust.GradeId;
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Course courseReqeust)
        {
            var course = await _db.Courses.FindAsync(courseReqeust.RecordNum);

            if (course != null)
            {
                _db.Courses.Remove(course);

                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
