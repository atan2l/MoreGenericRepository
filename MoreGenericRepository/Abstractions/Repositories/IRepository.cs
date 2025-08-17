using MoreGenericRepository.Abstractions.Wrappers;

namespace MoreGenericRepository.Abstractions.Repositories;

public interface IRepository<T> where T : IEntityWrapper
{
    void Add(T entity);

    T? Find(IKeyWrapper key);
}
