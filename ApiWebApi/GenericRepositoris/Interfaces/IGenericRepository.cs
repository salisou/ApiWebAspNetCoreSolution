namespace ApiWebApi.GenericRepositoris.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsinc();
        Task<T> GetByIdAsinc(int id);
        Task AddAsinc(T entity);
        Task UpdateAsinc(T entity);
        Task DeleteAsinc(int id);
    }
}
