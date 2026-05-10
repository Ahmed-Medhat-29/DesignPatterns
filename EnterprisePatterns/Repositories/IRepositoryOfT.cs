namespace EnterprisePatterns.Repositories;

interface IRepository<T>
{
    Task<T?> Get(int id);
    Task<IEnumerable<T>> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);

    Task SaveChanges();
}
