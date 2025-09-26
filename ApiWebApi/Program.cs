using ApiWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var strConnection = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApiWebContext>(options =>
    options.UseSqlite(strConnection)
);


// Configurazione dei servizi di CORS  (Da Non Toccare)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});

// Aggiunta dei controller
builder.Services.AddControllers();

// Configurazione di Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();

// Configurazione dettagliata di Swagger con informazioni personalizzate (Da Non Toccare)
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Corso di Programmazione C# © Talentform SpA 2025",
        Version = "v1",
        Description = "Documentazione API per il progetto ASP.NET Core con SQLite. " +
                   "Questa documentazione è stata generata automaticamente utilizzando Swagger.\n " +
                   "Per ulteriori informazioni, contattare il docente Moussa.",
        Contact = new OpenApiContact
        {
            Name = "Docente Moussa",
            Email = "moussa.software@gmail.com"
        }
    });

});

var app = builder.Build();

// Middleware per Swagger solo in ambiente di sviluppo (Da Non Toccare)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Versione 1");
        c.DocumentTitle = "Documentazione API - Docente Moussa";
        c.RoutePrefix = "swagger"; // oppure "" se vuoi che Swagger sia sulla root
    });


}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors("AllowAllOrigins");
app.MapControllers();
app.Run();
