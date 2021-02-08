using AutoMapper;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Infrastuctures.Services;
using CourseWebAPI.Models;
using CourseWebAPI.ResourceParamerters;
using CourseWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Controllers
{
    [Route("api/students")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        IEnrollmentService _enrollmentService;
        public StudentsController(IStudentService studentService,
            IEnrollmentService enrollmentService)
        {
            _studentService = studentService ??
                throw new ArgumentNullException(nameof(studentService));
            _enrollmentService = enrollmentService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetList(
            [FromQuery] StudentQueryParamerter param)
        {
            var collection = await _studentService.GetList(param);
            return Ok(collection);
        }
        [HttpGet("totalPage")]
        public async Task<IActionResult> GetTotalPage(int pageSize)
        {
            var totalPage = await _studentService.GetTotalPage(pageSize);
            return Ok(Math.Ceiling(totalPage));
        }

        [HttpGet("{studentId}", Name = "GetStudent")]
        public async Task<IActionResult> Get(int studentId)
        {
            var model = await _studentService.Get(studentId);
            if (model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult<StudentListModel>> Create(
            StudentModel newStudent)
        {
            await _studentService.Create(newStudent);
            return NoContent();
        }

        [HttpPost("{studentId}/enrollCourses")]
        public async Task<IActionResult> EnrollCourses(int studentId,
            [FromBody] params int[] courseIds)
        {
            await _enrollmentService.EnrollCourses(studentId, courseIds);
            return NoContent();
        }

        [HttpPut("{studentId}")]
        public async Task<ActionResult<StudentListModel>> Edit(int studentId,
            [FromBody] StudentModel student)
        {
            var existedModel = await _studentService.Get(studentId);
            if (existedModel == null)
            {
                return NotFound();
            }
            await _studentService.Update(studentId, student);
            return NoContent();
        }

        [HttpDelete("{studentId}")]
        public async Task<ActionResult<StudentListModel>> Delete(int studentId)
        {
            var existedModel = await _studentService.Get(studentId);
            if (existedModel == null)
            {
                return NotFound();
            }
            await _studentService.Delete(studentId);
            return NoContent();
        }
    }
}
