namespace ApiWebApi.GenericRepositoris.Interfaces
{
    /// <summary>
    /// Questa interfaccia definisce un repository generico per operazioni CRUD asincrone su entità di tipo T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /*
         * La diferenza tra Interfece e Class: 
         * L'innterface è un contratto che definisce un insieme di metodi e proprietà che una classe deve implementare, 
         * ma non fornisce implementazioni concrete. 
         * 
         * Una classe, d'altra parte, è una struttura che può contenere dati e implementazioni di metodi.
         * 
         * IEnumerable rappresenta una collezione di oggetti che possono essere enumerati. In questo contesto, viene utilizzato per restituire una collezione di entità di tipo T.
         * Task rappresenta un'operazione asincrona che può restituire un valore. In questo caso, viene utilizzato per operazioni asincrone che coinvolgono entità di tipo T.
         * Asinc indica che il metodo è asincrono, il che significa che può essere eseguito in modo non bloccante, consentendo al programma di continuare l'esecuzione mentre l'operazione è in corso.
         */
        Task<IEnumerable<T>> GetAllAsinc(); // Recupera tutte le entità di tipo T in modo asincrono.
        Task<T> GetByIdAsinc(int id); // Recupera un'entità di tipo T per ID in modo asincrono.
        Task AddAsinc(T entity); // Aggiunge una nuova entità di tipo T in modo asincrono.
        Task UpdateAsinc(T entity); // Aggiorna un'entità di tipo T esistente in modo asincrono.
        Task DeleteAsinc(int id); // Elimina un'entità di tipo T per ID in modo asincrono.
    }
}
