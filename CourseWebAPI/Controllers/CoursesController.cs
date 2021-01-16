using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Infrastuctures.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Controllers
{
    [Route("api/Courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _courseService;
        private IEnrollmentService _enrollmentService;
        public CoursesController(ICourseService courseService,
            IEnrollmentService enrollmentService)
        {
            _courseService = courseService;
            _enrollmentService = enrollmentService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetCourses()
        {
            var courseCollection = await _courseService.GetCourses();
            if (courseCollection == null)
                return NotFound();
            return Ok(courseCollection);
        }
        [HttpGet("{courseId}/enrollments")]
        public async Task<IActionResult> GetEnrolledStudents(int courseId)
        {
            var enrollmentCollection = await
                _enrollmentService.GetEnrollmentByCourse(courseId);
            if (enrollmentCollection == null)
                return NotFound();
            return Ok(enrollmentCollection);
        }
    }
}
