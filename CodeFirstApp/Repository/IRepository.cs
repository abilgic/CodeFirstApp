using System.Linq.Expressions;

namespace CodeFirstApp.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Remove(T entity);

    }
}
