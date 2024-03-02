using EduPulse.Application.Dtos;
using EduPulse.Domain.Entities;
using EduPulse.Infrastructure.Persistence;
using Mapster;
using MapsterMapper;

namespace EduPulse.Api.GraphQl;

public class Query 
{
    [UseOffsetPaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<StudentDto> GetPagedUsers([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Students.ProjectToType<StudentDto>();
    }
    
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<StudentDto> GetUsers([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Students.ProjectToType<StudentDto>();
    }
    
    [UseOffsetPaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<GroupDto> GetPagedGroups([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Groups.ProjectToType<GroupDto>();
    }
    
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<GroupDto> GetGroups([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Groups.ProjectToType<GroupDto>();
    }
    
    [UseOffsetPaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<TestDto> GetPagedTests([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Tests.ProjectToType<TestDto>();
    }
    
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<TestDto> GetTests([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Tests.ProjectToType<TestDto>();
    }
    
    [UseOffsetPaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<SubjectDto> GetPagedSubjects([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Subjects.ProjectToType<SubjectDto>();
    }
    
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<SubjectDto> GetSubjects([Service] EduPulseDbContext dbContext)
    {
        return dbContext.Subjects.ProjectToType<SubjectDto>();
    }
}