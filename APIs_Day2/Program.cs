using APIs_Day2_BL;
using APIs_Day2_BL.Helpers;
using APIs_Day2_BL.Services;
using APIs_Day2_DAL.Data.Context;
using APIs_Day2_DAL.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
#region default
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region DBConnection

var connectionString = builder.Configuration.GetConnectionString("Tickets");
builder.Services.AddDbContext<TicketsContext>(
    options => options.UseSqlServer(connectionString));

#endregion
#region Repositories
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
#endregion

#region services
builder.Services.AddScoped<ITicketSrvice, TicketService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

#endregion
//Register Auto Mapper
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(typeof(MappingProfile));

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
