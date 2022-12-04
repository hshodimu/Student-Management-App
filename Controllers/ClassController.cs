using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class ClassController : Controller
    {
        public readonly ApplicationDbContext _db;

        public ClassController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Class> objClassList = _db.Classes;
            return View(objClassList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddClassesViewModel addClassRequest) 
        {
            Class newClass = new Class()
            {
                ClassNumber = addClassRequest.ClassNumber,
                Term = addClassRequest.Term,
            };

            await _db.AddAsync(newClass);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int Id)
        {

            var classes = await _db.Classes.FirstOrDefaultAsync(x => x.Id == Id);

            if (classes != null)
            {
                var viewModel = new Class()
                {
                    ClassNumber = classes.ClassNumber,
                    Term = classes.Term,

                };

                return await Task.Run(() => View("Update", viewModel));
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Class updateClassReqeust)
        {

            var course = await _db.Classes.FindAsync(updateClassReqeust.Id);

            if (course != null)
            {
                course.ClassNumber = updateClassReqeust.ClassNumber;
                course.Term = updateClassReqeust.Term;
            }

            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Class updateClassReqeust)
        {
            var classes = await _db.Classes.FindAsync(updateClassReqeust.Id);

            if (classes != null)
            {
                _db.Classes.Remove(classes);

                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
