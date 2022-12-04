using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Models;
using static System.Collections.Specialized.BitVector32;

namespace StudentManagement.Controllers
{
    public class GradeController : Controller
    {
        public readonly ApplicationDbContext _db;

        public GradeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Grade> objList = _db.Grades;
            return View(objList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddGradeViewModel addGradeRequest)
        {

            var grade = new Grade()
            {
                GradeName = addGradeRequest.GradeName,
                Section = addGradeRequest.Section,
            };

            await _db.AddAsync(grade);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int Id)
        {

            var grade = await _db.Grades.FirstOrDefaultAsync(x => x.Id == Id);

            if (grade != null)
            {
                var viewModel = new Grade()
                {
                    GradeName = grade.GradeName,
                    Section = grade.Section

                };

                return await Task.Run(() => View("Update", viewModel));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Grade updateGradeReqeust)
        {

            var grade = await _db.Grades.FindAsync(updateGradeReqeust.Id);

            if (grade != null)
            {
                grade.GradeName = updateGradeReqeust.GradeName;
                grade.Section = updateGradeReqeust.Section;
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Grade gradeReqeust)
        {
            var grade = await _db.Grades.FindAsync(gradeReqeust.Id);

            if (grade != null)
            {
                _db.Grades.Remove(grade);

                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
