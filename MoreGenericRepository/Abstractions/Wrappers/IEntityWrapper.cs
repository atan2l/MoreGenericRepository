using MoreGenericRepository.Abstractions.Visitors;

namespace MoreGenericRepository.Abstractions.Wrappers;

public interface IEntityWrapper
{
    /// <summary>
    /// Accepts a visitor that returns no value
    /// </summary>
    /// <param name="visitor"></param>
    void Accept(IEntityVisitor visitor);

    /// <summary>
    /// Accepts a visitor that returns a value
    /// </summary>
    /// <param name="visitor"></param>
    /// <typeparam name="TRet"></typeparam>
    /// <returns></returns>
    TRet Accept<TRet>(IEntityVisitor<TRet> visitor);
}
