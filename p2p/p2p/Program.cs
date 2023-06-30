using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using p2pAPI.Models;
using System.Configuration;


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using static p2pAPI.Models.P2PContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



//builder.Services.AddDbContext<P2PContext>(opt =>
//    //opt.UseInMemoryDatabase("TodoList")
//    //opt.UseNpgsql(Configuration.GetConnectionString("myConnect")));
//    opt.UseNpgsql("\"server=localhost;port=5432;database=p2p_dotNet;user=Nath;password=1234;\"")
//);







//CreateHostBuilder(args).Build().Run();

//static IHostBuilder CreateHostBuilder(string[] args) =>
//    Host.CreateDefaultBuilder(args)
//        .ConfigureServices((hostContext, services) =>
//        {
//            var connectionString = "server=localhost;port=5432;database=p2p_dotNet;user=Nath;password=1234";

//            services.AddDbContext<P2PContext>(options =>
//                options.UseNpgsql(connectionString));

//            // Autres services à ajouter
//            // ...
//        });




// Configuration de la connexion à la base de données
var connectionString = builder.Configuration.GetConnectionString("myConnect");

builder.Services.AddDbContext<P2PContext>(options =>
    //options.UseNpgsql(connectionString));
    options.UseNpgsql("\"Server=localhost;Port=5432;Database=p2p_dotNet;User Id=Nath;Password=1234;\"")
);





//var configuration = new ConfigurationBuilder()
//    .SetBasePath(AppContext.BaseDirectory)
//    .AddJsonFile("appsettings.json")
//    .Build();

//var connectionString = configuration.GetConnectionString("myconnect");
//var optionsBuilder = new DbContextOptionsBuilder<P2PContext>();
//optionsBuilder.UseNpgsql(connectionString);

////using (var dbContext = new P2PContext(optionsBuilder.Options))
////{
////     dbContext.Database.Migrate();
////}





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
