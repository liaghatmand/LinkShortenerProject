using LinkShortenerProject.Application.Common.Interfaces;
using LinkShortenerProject.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace LinkShortenerProject.Infrastructure;

public static class ConfigServices
{
    public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services)
    {
        var ConnectionString = @"";

        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
                options.UseSqlServer(ConnectionString));
        return services;
    }
}
