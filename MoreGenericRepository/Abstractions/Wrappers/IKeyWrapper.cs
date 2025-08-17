using System.Diagnostics.CodeAnalysis;

namespace MoreGenericRepository.Abstractions.Wrappers;

public interface IKeyWrapper
{
    bool TryUnwrap<TWanted>([NotNullWhen(true)] out TWanted? key);
}
