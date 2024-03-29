using System.Reflection;
using EduPulse.Application.Common.Mediator;
using EduPulse.Application.Dtos;
using EduPulse.Application.Mediator.Commands.ScheduledEmails;
using EduPulse.Application.Mediator.Commands.Students;
using EduPulse.Application.Mediator.Commands.Tests;
using EduPulse.Application.Mediator.Commands.Users;
using FastExpressionCompiler;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EduPulse.Application.DependencyInjection;

public static class Application
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(mediatRServiceConfiguration =>
        {
            mediatRServiceConfiguration.Lifetime = ServiceLifetime.Scoped;
            
            mediatRServiceConfiguration.AddBehavior<TransactionalPipelineBehaviour<CloseTestCommand, TestDto>>();
            mediatRServiceConfiguration.AddBehavior<TransactionalPipelineBehaviour<OpenTestCommand, TestDto>>();
            mediatRServiceConfiguration.AddBehavior<TransactionalPipelineBehaviour<CreateTestCommand, TestDto>>();
            mediatRServiceConfiguration.AddBehavior<TransactionalPipelineBehaviour<UploadStudentAvatarCommand, Uri>>();
            mediatRServiceConfiguration.AddBehavior<TransactionalPipelineBehaviour<UploadTeacherAvatarCommand, Uri>>();
            mediatRServiceConfiguration.AddBehavior<TransactionalPipelineBehaviour<CreateScheduledEmailCommand, ScheduledEmailDto>>();
            mediatRServiceConfiguration.AddOpenBehavior(typeof(LoggingPipelineBehaviour<,>));
            
            mediatRServiceConfiguration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        
        services.AddMapster();
        TypeAdapterConfig.GlobalSettings.Compiler = expression => expression.CompileFast();
        
        return services;
    }
}