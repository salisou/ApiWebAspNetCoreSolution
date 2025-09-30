using ApiWebApi.Data;
using ApiWebApi.GenericRepositoris.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ApiWebApi.GenericRepositoris.Repositories
{
    /// <summary>
    /// Questa classe implementa un repository generico per operazioni CRUD asincrone su entità di tipo T.
    /// </summary>
    /// <typeparam name="T">Tipo dell'entità gestita (ad esempio Studente, Corso, ecc.).</typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // Riferimento al DbContext, che rappresenta la connessione al database
        private readonly ApiWebContext _context;

        // Riferimento al DbSet dell'entità T (una "tabella" del database)
        private readonly DbSet<T> _dbSet;

        // Costruttore: riceve il DbContext tramite Dependency Injection
        public GenericRepository(ApiWebContext context)
        {
            _context = context;             // assegna il DbContext al campo privato
            _dbSet = context.Set<T>();      // ottiene il DbSet per il tipo T (es: _context.Set<Studente>())
        }

        // Restituisce tutte le entità di tipo T in forma asincrona
        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        // Cerca un'entità per ID nel DbSet
        public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        // Crea (inserisce) una nuova entità nel DbSet
        public async Task<T> CreateAsync(T entity)
        {
            try
            {
                // Aggiunge l'entità in modo asincrono al DbSet
                EntityEntry<T> value = await _dbSet.AddAsync(entity)
                    ?? throw new Exception("Impossibile aggiungere l'entità al DbSet.");

                // Salva le modifiche nel database
                await _context.SaveChangesAsync();

                // Restituisce l'entità creata
                return entity;
            }
            catch (Exception ex)
            {
                // In caso di errore, rilancia un'eccezione più descrittiva
                throw new Exception("Errore durante la creazione dell'entità.", ex);
            }
        }

        // Aggiorna un'entità esistente con i valori di una nuova
        public async Task<T?> UpdateAsync(int id, T entity)
        {
            try
            {
                // Cerca l'entità esistente nel DbSet
                T existing = await _dbSet.FindAsync(id)
                    ?? throw new Exception("Entità non trovata."); // se non esiste, lancia un'eccezione

                // Aggiorna i valori correnti dell'entità trovata con quelli della nuova entità
                _context.Entry(existing).CurrentValues.SetValues(entity);

                // Salva i cambiamenti nel database
                await _context.SaveChangesAsync();

                // Restituisce l'entità aggiornata
                return existing;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'aggiornamento dell'entità.", ex);
            }
        }

        // Elimina un'entità dal DbSet a partire dal suo ID
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                // Recupera l'entità da eliminare
                T? entity = await GetByIdAsync(id);

                // Se non esiste, ritorna false (niente da cancellare)
                if (entity == null)
                {
                    return false;
                }

                // Rimuove l'entità dal DbSet
                _dbSet.Remove(entity);

                // Salva i cambiamenti nel database
                await _context.SaveChangesAsync();

                // Restituisce true se l'eliminazione è riuscita
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'eliminazione dell'entità.", ex);
            }
        }
    }
}
