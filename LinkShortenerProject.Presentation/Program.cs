using LinkShortenerProject.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.RegisterInfrastructureServices();
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}