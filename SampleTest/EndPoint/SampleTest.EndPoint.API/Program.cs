using Microsoft.EntityFrameworkCore;
using SampleTest.Core.ApplicationServices;
using SampleTest.Core.Domain;
using SampleTest.Infra.EFSql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("SampleTestDB");

//var connectionString = builder.Configuration.GetConnectionString("sajad");
builder.Services.AddDbContext<SubjectContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ISubjectService, SubjectService>();





////////////////////////////////////////////////
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
