using MoreGenericRepository.Abstractions.Visitors;
using MoreGenericRepository.Abstractions.Wrappers;

namespace MoreGenericRepository.Entities;

public abstract class BaseEntity<TKey> : IEntityWrapper
{
    public TKey? Id { get; set; }

    public void Accept(IEntityVisitor visitor)
    {
        visitor.Visit(this);
    }

    public TRet Accept<TRet>(IEntityVisitor<TRet> visitor)
    {
        return visitor.Visit(this);
    }
}
