﻿using AutoMapper;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Infrastuctures.Services;
using CourseWebAPI.Models;
using CourseWebAPI.ResourceParamerters;
using CourseWebAPI.Services;
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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentsController> _logger;
        private readonly ICourseService _courseService;
        public StudentsController(IStudentService studentService, 
            ILogger<StudentsController> logger, ICourseService courseService)
        {
            _studentService = studentService ??
                throw new ArgumentNullException(nameof(studentService));
            _logger = logger;
            _courseService = courseService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetStudents(
            [FromQuery] StudentQueryParamerter param)
            => Ok(await _studentService.GetStudents(param));

        [HttpGet("{studentId}", Name = "GetStudent")]
        public async Task<IActionResult> GetStudent(int studentId)
        {
            var student = await _studentService.GetStudent(studentId);
            if (student == null)
                return NotFound();
            else
                return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<StudentDto>> CreateStudent(
            StudentForManipulationDto newStudent)
        {
            await _studentService.Add(newStudent);
            return NoContent();
        }

        [HttpPost("{studentId}/enrollments")]
        public async Task<IActionResult> CreateEnrollment(int studentId,
            [FromBody] params int[] courseIds)
        {
            if(is)

            bool IsExsit(int studentId, params int[] courseIds)
                => _studentService.IsExist(studentId) &&
                _courseService.IsExist(courseIds);
        }

        [HttpPut("{studentId}")]
        public async Task<ActionResult<StudentDto>> UpdateStudent(int studentId,
            [FromBody] StudentForManipulationDto student)
        {
            var studentFromRespo = await _studentService.GetStudent(studentId);
            if (studentFromRespo == null)
                return NotFound();
            await _studentService.Update(studentId, student);
            return NoContent();
        }

        [HttpDelete("{studentId}")]
        public async Task<ActionResult<StudentDto>> DeleteStudent(int studentId)
        {
            var studentFromRespo = await _studentService.GetStudent(studentId);
            if (studentFromRespo == null)
                return NotFound();
            await _studentService.Delete(studentId);
            return NoContent();
        }
    }
}
