using DomainLayer.Common;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Interfaces
{
	public interface IRepository<T> where T : BaseEntity
	{
		Task<List<T>> GetAllAsync();
		Task<T> GetAsync(string id);
		Task CreateAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task SoftDeleteAsync(T entity);
		Task<T> FindAsync(Expression<Func<T, bool>> predicate);
		Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
	}
}
