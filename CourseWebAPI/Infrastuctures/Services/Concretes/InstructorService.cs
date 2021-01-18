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
        public async Task<List<InstructorListModel>> GetList()
        {
            List<InstructorListModel> models = new List<InstructorListModel>();
            var entities = await
                _context.Instructors.Include(i => i.OfficeAssignment).ToListAsync();
            foreach (var entity in entities)
            {
                var model = _mapper.Map<InstructorListModel>(entity);
                model.Departments = await GetDepartmentNames(model.Id);
                model.Courses = await GetCourseTitles(entity);
                models.Add(model);
            }
            return models;
        }

        public async Task<InstructorListModel> Get(int instructorId)
        {
            var entity = await
                _context.Instructors.Include(i => i.OfficeAssignment)
                .FirstOrDefaultAsync(i => i.ID == instructorId);
            if (entity == null)
                return null;

                var instructorDto = _mapper.Map<InstructorListModel>(entity);
                //instructorDto.Departments = await GetDepartmentNames(instructorDto.Id);
                instructorDto.Courses = await GetCourseTitles(entity);
            return instructorDto;
        }

        public async Task<bool> Create(InstructorCreateModel model)
        {
            var entity = _mapper.Map<Instructor>(model);
            _context.Instructors.Add(entity);
            return  await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(int instructorId,
            InstructorEditModel model)
        {
            var entity = await
                _context.Instructors.Include(i => i.OfficeAssignment)
                .FirstOrDefaultAsync(i => i.ID == instructorId);
            _mapper.Map<InstructorEditModel, Instructor>(model, entity);
                
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Delete(int instructorId)
        {
            var entity = _context.Instructors
                .Include(x => x.CourseAssignments)
                .FirstOrDefault(x => x.ID == instructorId);
            _context.Instructors.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
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
