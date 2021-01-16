using CourseWebAPI.Infrastuctures.Models;
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
        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetInstructors()
        {
            var instructorCollection = await _instructorService.GetInstructors();
            if (instructorCollection == null || instructorCollection.Count == 0)
                return NotFound();
            return Ok(instructorCollection);
        }

        [HttpGet("{instructorId}")]
        public async Task<IActionResult> GetInstructor(int instructorId)
        {
            var instructor = await _instructorService.GetInstructor(instructorId);
            if (instructor == null)
                return NotFound();
            return Ok(instructor);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateInstructor(
            [FromBody] InstructorForCreationDto instructor)
        {
            bool createSucceed = await _instructorService.CreateInstructor(instructor);
            if (createSucceed)
                return NoContent();
            return BadRequest();
        }

        [HttpPut("{instructorId}")]
        public async Task<IActionResult> UpdateInstructor(int instructorId,
            [FromBody] InstructorForUpdateDto instructor)
        {
            if(await _instructorService.GetInstructor(instructorId) == null)
                return NotFound();

            bool updateSucceed = await
                _instructorService.UpdateInstructor(instructorId, instructor);
            if (updateSucceed)
                return NoContent();
            return BadRequest();
        }

        [HttpDelete("{instructorId}")]
        public async Task<IActionResult> DeleteInstructor(int instructorId)
        {
            bool deleteSucceed = await _instructorService.DeleteInstructor(instructorId);
            if (deleteSucceed)
                return NoContent();
            return NotFound();
        }
    }
}
