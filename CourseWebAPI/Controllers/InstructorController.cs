using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Infrastuctures.Services;
using CourseWebAPI.Models;
using CourseWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Controllers
{
    [Route("api/Instructors")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private IInstructorService _instructorService;
        private ICourseService _courseService;
        private ICourseAssignmentService _courseAssignmentService;
        public InstructorController(IInstructorService instructorService,
            ICourseService courseService,
            ICourseAssignmentService courseAssignmentService)
        {
            _instructorService = instructorService;
            _courseService = courseService;
            _courseAssignmentService = courseAssignmentService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetList()
        {
            var collection = await _instructorService.GetList();
            return Ok(collection);
        }

        [HttpGet("{instructorId}")]
        public async Task<IActionResult> Get(int instructorId)
        {
            var instructor = await _instructorService.Get(instructorId);
            if (instructor == null)
            {
                return NotFound();
            }
            return Ok(instructor);
        }

        [HttpGet("{instructorId}/courses")]
        public async Task<IActionResult> GetTaughtCourses(int instructorId)
        {
            var collection = await _courseService.GetTaughtCourses(instructorId);
            return Ok(collection);
        }

        [HttpPost()]
        public async Task<IActionResult> Create(
            [FromBody] InstructorModel instructor)
        {
            await _instructorService.Create(instructor);
            return NoContent();
        }

        [HttpPost("{instructorId}/assignCourses")]
        public async Task<IActionResult> AssignCourses(int instructorId,
            [FromBody] params int[] courseIds)
        {
            await _courseAssignmentService.AssignCourses(instructorId, courseIds);
            return NoContent();
        }

        [HttpPut("{instructorId}")]
        public async Task<IActionResult> Edit(int instructorId,
            [FromBody] InstructorModel instructor)
        {
            var existedModel = await _instructorService.Get(instructorId);
            if (existedModel == null)
            {
                return NotFound();
            }
            await _instructorService.Edit(instructorId, instructor);
            return NoContent();
        }

        [HttpDelete("{instructorId}")]
        public async Task<IActionResult> Delete(int instructorId)
        {
            await _instructorService.Delete(instructorId);
            return NoContent();
        }
    }
}
