using System.Dynamic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using StudentManagement.Data;
using StudentManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentManagement.Controllers
{
	public class StudentController : Controller
	{
		public readonly ApplicationDbContext _db;

		public StudentController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<Student> objStudentsList = _db.Students;
			return View(objStudentsList);
		}

		[HttpGet]
		public IActionResult Add()
		{
			
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddStudentViewModel addStudentRequest)
		{
            var student = new Student()
				{
					Name = addStudentRequest.Name,
					Dob = addStudentRequest.Dob,
					GradeId = addStudentRequest.GradeId,
					ClassId = addStudentRequest.ClassId
				};

			await _db.Students.AddAsync(student);
			await _db.SaveChangesAsync();

            return RedirectToAction("Index");
		}

        [HttpGet]
        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(int id)
        {
            var query = from st in _db.Students
                            where st.Id == id
                            select st;

            var student = query.FirstOrDefault<Student>();

			if (student != null) 
			{ 
				return View(student);
			} else
			{
				return View();
			}
        }

		[HttpGet]

		public async Task<IActionResult> Update(int Id) 
		{
			var student = await _db.Students.FirstOrDefaultAsync(x => x.Id == Id);

			if (student != null) 
			{
                var viewModel = new Student()
                {
                    Id = student.Id,
                    Name = student.Name,
                    Dob = student.Dob,
                    GradeId = student.GradeId,
                    ClassId = student.ClassId,
					Courses = student.Courses
                };

				return await Task.Run(() => View("Update", viewModel));
            }

            return RedirectToAction("Index");
        }

		[HttpPost]

		public async Task<IActionResult> Update(Student studentPost)
		{
			var student = await _db.Students.FindAsync(studentPost.Id);
			var courses = _db.Courses.Where(c => c.GradeId == student.GradeId);

			if (student != null)
			{
				student.Id = studentPost.Id; 
				student.Name = studentPost.Name; 
				student.Dob = studentPost.Dob;
				student.GradeId = studentPost.GradeId;
				student.ClassId = studentPost.ClassId;

				foreach(Course course in courses)
				{
					if (studentPost.Courses.Contains(course))
					{
						student.Courses.Add(course);
					}
                    

                }
				
			}

			await _db.SaveChangesAsync();

			return RedirectToAction("Index");
		}

        [HttpPost]
        public async Task<IActionResult> Delete(Student studentReqeust)
        {
            var student = await _db.Students.FindAsync(studentReqeust.Id);

            if (student != null)
            {
                _db.Students.Remove(student);

                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
