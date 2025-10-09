# Esercizio Completo ApiWebAspNetCoreSolution
## REST API con Entity Framework e .NET 8/9 

Benvenuto in questa repository! 
Qui troverai tutto il codice relativo all'esercizio pratico sulla creazione di una REST API utilizzando Entity Framework e .NET 8/9. 
L'esercizio è suddiviso in due parti principali: **Frontend** e **Backend**, con una configurazione completa del database tramite SQLite.

### Questo progetto dimostra l'uso del Repository Pattern con SQLite per gestire CRUD

<img width="518" height="312" alt="immagine" src="https://github.com/user-attachments/assets/33ac4328-ef9c-410d-af87-26c7ff54c3a2" />

____________________________________________________________________________________________________________

## Tecnologie
- ASP.NET Core Web API
- SQLite
- Repository Pattern
- DTO
- Swagger

## Struttura
- Models
    - Studenti 
    - Corsi 
- Converts
- DTOs
    - StudentiDtos 
    - CorsiDtos 
- Data
- GenericRepositories
  - Interfaces
  - Repositories
  - Services
- Controllers
-  Mappings
-  Wrappers

## Avvio
1. `dotnet restore`
2. `dotnet ef migrations add InitialCreate`
3. `dotnet ef database update`
4. `dotnet run`

