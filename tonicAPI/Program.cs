using Microsoft.EntityFrameworkCore;
using tonicAPI.Models;
using tonicAPI.Models.Repository;
using tonicAPI.Models.DataManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ToDoDBContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("ItemsDB")));
builder.Services.AddScoped<DataRepository<ToDoItem>, DataManager>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
