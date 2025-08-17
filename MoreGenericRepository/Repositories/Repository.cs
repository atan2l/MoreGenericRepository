using MoreGenericRepository.Abstractions.Repositories;
using MoreGenericRepository.Abstractions.Visitors;
using MoreGenericRepository.Abstractions.Wrappers;
using MoreGenericRepository.Entities;

namespace MoreGenericRepository.Repositories;

public class Repository<T> : IRepository<T> where T : IEntityWrapper
{
    private readonly List<T> _entities;

    public Repository()
    {
        _entities = [];
    }

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public T? Find(IKeyWrapper key)
    {
        MatchByKeyVisitor visitor = new(key);
        return _entities.SingleOrDefault(x => x.Accept(visitor));
    }

    private sealed class MatchByKeyVisitor : IEntityVisitor<bool>
    {
        private readonly IKeyWrapper _key;

        public MatchByKeyVisitor(IKeyWrapper key)
        {
            _key = key;
        }

        public bool Visit<TKey>(BaseEntity<TKey> entity)
        {
            return _key.TryUnwrap(out TKey? key) && EqualityComparer<TKey>.Default.Equals(entity.Id, key);
        }
    }
}
