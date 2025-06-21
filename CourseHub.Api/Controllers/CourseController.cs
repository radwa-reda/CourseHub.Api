
using CourseHub.Domain.Entities;
using CourseHub.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CourseHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
          _context= context;
        }

        [HttpGet]
        public ActionResult<List<Course>> GetAllCourses()
        {
            return _context.Courses.ToList(); // Convert DbSet<Course> to List<Course> using ToList()
        }

        [HttpGet("{id}")]
        public ActionResult <Course> GetCourseById(int id)
        {
            var course= _context.Courses.FirstOrDefault(p=> p.Id==id);
            if (course == null) { return NotFound(); }
            return course;
        }

        [HttpPost]
        public ActionResult<Course> AddCourse(Course course)
        {
            _context.Courses.Add(course);
            return Ok("Course is Creaded  sucssfully");
        }

        [HttpPut("{id}")]
        public ActionResult<Course> UpdateCourse(int id, Course updated)
        {
            var oldcourse = _context.Courses.FirstOrDefault(p => p.Id == id);
            if (oldcourse == null) { return NotFound(); }
            oldcourse.Name = updated.Name;
            oldcourse.Description = updated.Description;
            return Ok("Course is updated  sucssfully");
        }

        [HttpDelete("{id}")]
        public ActionResult<Course> DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(p => p.Id == id);
            if (course == null) { return NotFound(); }
            _context.Courses.Remove(course);
            return Ok("Course is delete  sucssfully");
        }
    }
}
