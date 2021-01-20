using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Models;
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
            var entities = await
                _context.Instructors.AsNoTracking()
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                .ThenInclude(oa => oa.Course)
                .ToListAsync();
            var models = _mapper.Map<List<InstructorListModel>>(entities);
            return models;
        }

        public async Task<InstructorListModel> Get(int instructorId)
        {
            var entity = await
                _context.Instructors.AsNoTracking()
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                .ThenInclude(oa => oa.Course)
                .FirstOrDefaultAsync(i => i.ID == instructorId);
            var model = (entity != null) ? _mapper.Map<InstructorListModel>(entity) : null;
            return model;
        }

        public async Task Create(InstructorModel model)
        {
            var entity = _mapper.Map<Instructor>(model);
            _context.Instructors.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Edit(int instructorId,
            InstructorModel model)
        {
            var entity = await
                _context.Instructors
                .Include(i => i.OfficeAssignment)
                .FirstOrDefaultAsync(i => i.ID == instructorId);
            _mapper.Map<InstructorModel, Instructor>(model, entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int instructorId)
        {
            var entity = _context.Instructors
                //.Include(x => x.CourseAssignments)
                .FirstOrDefault(x => x.ID == instructorId);
           // _context.CourseAssignments.RemoveRange(entity.CourseAssignments);
            _context.Instructors.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
