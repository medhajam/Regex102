using Regex102.Application;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddApplication();

    builder.Logging.AddConsole();
    builder.Logging.AddDebug();
}

var app = builder.Build();

{

    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseMiddleware<ExceptionHandlingMiddleware>();
    app.UseHttpsRedirection();

    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}

