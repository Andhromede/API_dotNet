using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using p2pAPI.Models;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddDbContext<P2PContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("myConnect"))
);

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
