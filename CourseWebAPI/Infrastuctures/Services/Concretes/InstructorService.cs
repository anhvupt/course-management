using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;
        public InstructorService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<InstructorDto>> GetInstructors()
        {
            List<InstructorDto> dtoCollection = new List<InstructorDto>();
            var instructorsInDb = await
                _context.Instructors.Include(i => i.OfficeAssignment).ToListAsync();
            foreach (var instuctor in instructorsInDb)
            {
                var instructorDto = _mapper.Map<InstructorDto>(instuctor);
                instructorDto.Departments = await GetDepartmentNames(instructorDto.Id);
                instructorDto.Courses = await GetCourseTitles(instuctor);
                dtoCollection.Add(instructorDto);
            }
            return dtoCollection;
        }

        public async Task<InstructorDto> GetInstructor(int instructorId)
        {
            InstructorDto instructorDto = null;
            var instructorInDb = await
                _context.Instructors.Include(i => i.OfficeAssignment)
                .FirstOrDefaultAsync(i => i.ID == instructorId);
            if (instructorInDb != null)
            {
                instructorDto = _mapper.Map<InstructorDto>(instructorInDb);
                instructorDto.Departments = await GetDepartmentNames(instructorDto.Id);
                instructorDto.Courses = await GetCourseTitles(instructorInDb);
            }
            return instructorDto;
        }

        public async Task<bool> CreateInstructor(InstructorForCreationDto instructor)
        {
            var newInstructor = _mapper.Map<Instructor>(instructor);
            _context.Instructors.Add(newInstructor);
            bool creationSucceed = await _context.SaveChangesAsync() > 0;
            if (creationSucceed)
            {
                if (!string.IsNullOrWhiteSpace(instructor.Office))
                {
                    OfficeAssignment newOfficeAssignment = new OfficeAssignment()
                    {
                        InstructorID = newInstructor.ID,
                        Location = instructor.Office
                    };
                    _context.OfficeAssignments.Add(newOfficeAssignment);
                    creationSucceed &= await _context.SaveChangesAsync() > 0;
                }
                return creationSucceed;
            }
            return false;
        }
        public async Task<bool> UpdateInstructor(int instructorId,
            InstructorForUpdateDto instructor)
        {
            var instructorInDb = await
                _context.Instructors.Include(i => i.OfficeAssignment)
                .FirstOrDefaultAsync(i => i.ID == instructorId);

            var newInstructor = _mapper.Map<Instructor>(instructor);
            instructorInDb.FirstMidName = newInstructor.FirstMidName;
            instructorInDb.LastName = newInstructor.LastName;
            instructorInDb.HireDate = newInstructor.HireDate;
            instructorInDb.OfficeAssignment.Location = instructor.Office;

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteInstructor(int instructorId)
        {
            var officeAssignment = await _context.OfficeAssignments
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.InstructorID == instructorId);
            var instructor = await _context.Instructors
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == instructorId);

            if (officeAssignment != null)
                _context.OfficeAssignments.Remove(officeAssignment);
            if (instructor != null)
                _context.Instructors.Remove(instructor);

            return await _context.SaveChangesAsync() > 0;
        }

        public bool IsExist(params int[] ids)
        {
            foreach (var id in ids)
                if (!_context.Instructors.Any(i => i.ID == id))
                    return false;
            return true;
        }

        private async Task<List<string>> GetDepartmentNames(int instructorId)
        {
            List<string> result = new List<string>();
            var departments = await
                _context.Departments.Where(d => d.InstructorID == instructorId)
                .AsNoTracking()
                .ToListAsync();
            foreach (var department in departments)
                result.Add(department?.Name);
            return result;
        }
        private async Task<List<string>> GetCourseTitles(Instructor instructor)
        {
            List<string> result = new List<string>();
            await _context.Entry(instructor)
                .Collection(i => i.CourseAssignments).LoadAsync();
            foreach (var ca in instructor.CourseAssignments)
            {
                _context.Entry(ca).Reference(ca => ca.Course).Load();
                result.Add(ca.Course.Title);
            }
            return result;
        }


    }
}
