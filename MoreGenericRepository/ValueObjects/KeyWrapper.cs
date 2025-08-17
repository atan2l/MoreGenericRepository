using System.Diagnostics.CodeAnalysis;
using MoreGenericRepository.Abstractions.Wrappers;

namespace MoreGenericRepository.ValueObjects;

public sealed class KeyWrapper<TKey> : IKeyWrapper
{
    private readonly TKey _key;

    public KeyWrapper(TKey key)
    {
        _key = key;
    }

    public bool TryUnwrap<TWanted>([NotNullWhen(true)] out TWanted? key)
    {
        if (_key is TWanted k)
        {
            key = k;
            return true;
        }

        key = default;
        return false;
    }
}
