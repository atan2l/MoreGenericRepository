using MoreGenericRepository.Entities;

namespace MoreGenericRepository.Abstractions.Visitors;

/// <summary>
/// Interface for a visitor whose visit method performs an operation which returns a value
/// </summary>
/// <typeparam name="TRet"></typeparam>
public interface IEntityVisitor<out TRet>
{
    TRet Visit<TKey>(BaseEntity<TKey> entity);
}

/// <summary>
/// Interface for a visitor whose visit method performs an operation which returns no value
/// </summary>
public interface IEntityVisitor
{
    void Visit<TKey>(BaseEntity<TKey> entity);
}
