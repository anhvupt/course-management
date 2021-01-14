using AutoMapper;
using CourseData.Infrastructures.Services;
using CourseDomain;
using CourseDomain.Models;
using CourseDomain.ResourceParamerters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IStudentRespository _studentRespository;
        private readonly IMapper _mapper;
        public StudentsController(IStudentRespository studentRespository, IMapper mapper)
        {
            _studentRespository = studentRespository ?? 
                throw new ArgumentNullException(nameof(studentRespository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet()]
        [HttpHead]
        public ActionResult<IEnumerable<StudentDto>> GetStudent([
            FromQuery]StudentResourceParamerter param)
        {
            var students = _studentRespository.Get(param);
            return Ok(_mapper.Map<IEnumerable<StudentDto>>(students));
        }

        [HttpGet("{studentId}", Name = "GetStudent")]
        public ActionResult<StudentDto> GetStudent(int studentId)
        {
            var studentFromRespo = _studentRespository.Get(studentId);
            if (studentFromRespo == null)
                return NotFound();
            else
                return Ok(_mapper.Map<StudentDto>(studentFromRespo));
        }

        [HttpPost]
        public ActionResult<StudentDto> CreateStudent(
            StudentForManipulationDto newStudent)
        {
            var studentEntity = _mapper.Map<Student>(newStudent);
            _studentRespository.Add(studentEntity);
            _studentRespository.Save();

            var studentToReturn = _mapper.Map<StudentDto>(studentEntity);
            return CreatedAtRoute("GetStudent",
                new { studentId = studentToReturn.Id },
                studentToReturn);
        }

        [HttpPut("{studentId}")]
        public ActionResult<StudentDto> UpdateStudent(int studentId,
            [FromBody] StudentForManipulationDto student)
        {
            var studentFromRespo = _studentRespository.Get(studentId);
            if(studentFromRespo == null)
            {
                var studentToAdd = _mapper.Map<Student>(student);
                studentToAdd.Id = studentId;

                _studentRespository.Add(studentToAdd);
                _studentRespository.Save();

                var studentToReturn = _mapper.Map<StudentDto>(studentToAdd);
                return CreatedAtRoute("GetStudent",
                    new { studentId = studentToReturn.Id },
                    studentToReturn);
            }
            _mapper.Map(student, studentFromRespo);
            _studentRespository.Update(studentFromRespo);
            _studentRespository.Save();
            return NoContent();
        }

        [HttpDelete("{studentId}")]
        public ActionResult<StudentDto> DeleteStudent(int studentId)
        {
            var studentFromRespo = _studentRespository.Get(studentId);
            if (studentFromRespo == null)
                return NotFound();
            _studentRespository.Delete(studentFromRespo);
            _studentRespository.Save();
            return NoContent();
        }
    }
}
