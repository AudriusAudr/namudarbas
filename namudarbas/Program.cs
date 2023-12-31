using namudarbas.Interfaces;
using namudarbas.Repositories;
using namudarbas.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IPaskaitaRepository, PaskaitaRepository>();

builder.Services.AddTransient<IPaskaitaService, PaskaitaService>();


builder.Services.AddTransient<IStudentasRepository, StudentasRepository>();

builder.Services.AddTransient<IStudentasService, StudentasService>();



builder.Services.AddTransient<IDepartamentasRepository,DepartamentasRepository>();

builder.Services.AddTransient<IDepartamentasService, DepartamentasService>();


var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
