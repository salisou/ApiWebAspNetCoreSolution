using ApiWebApi.Data;
using ApiWebApi.GenericRepositories.Repositories;
using ApiWebApi.GenericRepositories.Servises;
using ApiWebApi.GenericRepositoris.Interfaces;
using ApiWebApi.GenericRepositoris.Repositories;
using ApiWebApi.GenericRepositoris.Servises;
using ApiWebApi.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

#region Configurazione di Serilog
builder.Host.UseSerilog((ctx, lc) =>
{
    lc.WriteTo.Console()
      .ReadFrom.Configuration(ctx.Configuration);
});
#endregion

#region Configurazione di EF Core DbContext
var strConnection = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApiWebContext>(options =>
    options.UseSqlite(strConnection)
);
#endregion

#region Dependency Injection

/* =================================================================================================
   Configurazione Dependency Injection (Scoped)

   - IGenericRepository<> → ogni entità che richiede un repository riceverà 
     un’istanza dedicata di GenericRepository<T> valida per la durata della richiesta HTTP.

   - StudentiService → per ogni richiesta HTTP viene creata una nuova istanza 
     che utilizza a sua volta il repository corrispondente.
   ================================================================================================ */

/* ======================================================================================================
 * Registra nel container di Dependency Injection il repository generico.                                =
 * typeof(IGenericRepository<>) indica un'interfaccia generica aperta (senza tipo specifico).            =
 * typeof(GenericRepository<>) è la sua implementazione concreta.                                        =
 * AddScoped significa che ogni richiesta HTTP avrà la propria istanza del repository.                   =
 * In pratica: quando inietti IGenericRepository<Studenti>, verrà fornito un GenericRepository<Studenti>.*/

// Inject Interface and Repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

// Repository specifico per corsi
builder.Services.AddScoped(typeof(GenericRepository<>));
builder.Services.AddScoped<CorsiRepository>();


/* ================================================================================================
 * Registra il servizio StudentiService come "scoped".                                            =
 * AddScoped<StudentiService>() equivale a dire:                                                  =
 * ogni volta che qualcuno chiede uno StudentiService (nel costruttore di un controller o altro), =
 * il container creerà un'istanza e la manterrà per tutta la durata della singola richiesta HTTP. =
 * Non serve passare l'interfaccia se la classe non ne implementa una: usi direttamente la classe.*/
builder.Services.AddScoped<StudentiService>();
builder.Services.AddScoped<CorsiService>(); // se fai anche il service per corsi

/* =================================================================================================* 
 *   AutoMapper Configuration                                                                      *
 *   AutoMapper è una libreria che semplifica la mappatura tra oggetti di tipi diversi,            *
 *   riducendo la necessità di scrivere codice di conversione manuale.                             *
 *   Qui registriamo il profilo di mapping definito in MappingProfile.cs                           *
 ================================================================================================== */
builder.Services.AddAutoMapper(typeof(MappingProfile));
#endregion

#region Configurazione dei servizi di CORS  (Da Non Toccare)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});
#endregion

// Aggiunta dei controller
builder.Services.AddControllers();

#region Configurazione di Swagger/OpenAPI
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
#endregion

var app = builder.Build();

#region Enable Swagger only in development
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
#endregion
app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors("AllowAllOrigins");
app.MapControllers();
app.Run();
