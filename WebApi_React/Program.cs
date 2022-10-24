using Microsoft.EntityFrameworkCore;
using WebApi_React.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Configure the Sql Server Database ConnectionStrings
builder.Services.AddDbContext<reactContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("TEConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
