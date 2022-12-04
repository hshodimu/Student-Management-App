using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class TeacherController : Controller
    {
        public readonly ApplicationDbContext _db;

        public TeacherController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Teacher> objList = _db.Teachers;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTeacherViewModel addTeacherRequest)
        {

            var teacher = new Teacher()
            {
                Name = addTeacherRequest.Name,
                HomeroomNumber = addTeacherRequest.HomeroomNumber,
                Department = addTeacherRequest.Department,
                CourseId = addTeacherRequest.CourseId,
            };
            

            await _db.Teachers.AddAsync(teacher);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int Id)
        {

            var teacher = await _db.Teachers.FirstOrDefaultAsync(x => x.Id == Id);

            if (teacher != null)
            {
                var viewModel = new Teacher()
                {
                    Id = teacher.Id,
                    Name = teacher.Name,
                    HomeroomNumber = teacher.HomeroomNumber,
                    Department = teacher.Department,
                    CourseId = teacher.CourseId,

                };

                return await Task.Run(() => View("Update", viewModel));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Teacher updateTeacherReqeust)
        {

            var teacher = await _db.Teachers.FindAsync(updateTeacherReqeust.Id);

            if (teacher != null)
            {
                teacher.Name = updateTeacherReqeust.Name;
                teacher.HomeroomNumber = updateTeacherReqeust.HomeroomNumber;
                teacher.Department = updateTeacherReqeust.Department;
                teacher.CourseId = updateTeacherReqeust.CourseId;
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Teacher updateTeacherReqeust)
        {
            var teacher = await _db.Teachers.FindAsync(updateTeacherReqeust.Id);

            if (teacher != null)
            {
                _db.Teachers.Remove(teacher);

                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
