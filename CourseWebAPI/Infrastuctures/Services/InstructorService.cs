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
            var instructorsInDb = await
                _context.Instructors.Include(i => i.OfficeAssignment)
                .AsNoTracking()
                .ToListAsync();
            var instructorCollection = _mapper.Map<List<InstructorDto>>(instructorsInDb);
            foreach (var instuctor in instructorCollection)
            {
                var departments = await
                    _context.Departments.Where(d => d.InstructorID == instuctor.Id)
                    .AsNoTracking()
                    .ToListAsync();
                foreach (var department in departments)
                    instuctor.Departments.Add(department?.Name);
            }
            return instructorCollection;
        }

        public async Task<InstructorDto> GetInstructor(int instructorId)
        {
            InstructorDto instructor = null;
            var instructorInDb = await
                _context.Instructors.Include(i => i.OfficeAssignment)
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.ID == instructorId);
            if (instructorInDb != null)
            {
                instructor = _mapper.Map<InstructorDto>(instructorInDb);
                var departments = await
                    _context.Departments.Where(d => d.InstructorID == instructor.Id)
                    .AsNoTracking()
                    .ToListAsync();
                foreach (var department in departments)
                    instructor.Departments.Add(department?.Name);
            }
            return instructor;
        }

        public async Task<bool> CreateInstructor(InstructorForCreationDto instructor)
        {
            var newInstructor = _mapper.Map<Instructor>(instructor);
            _context.Instructors.Add(newInstructor);
            bool creationSucceed = await _context.SaveChangesAsync() > 0;
            if (creationSucceed)
            {
                if (!string.IsNullOrWhiteSpace(instructor.Location))
                {
                    OfficeAssignment newOfficeAssignment = new OfficeAssignment()
                    {
                        InstructorID = newInstructor.ID,
                        Location = instructor.Location
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
            instructorInDb.OfficeAssignment.Location = instructor.Location;

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
    }
}
