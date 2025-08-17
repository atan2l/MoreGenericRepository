using MoreGenericRepository.Abstractions.Wrappers;
using MoreGenericRepository.ValueObjects;

namespace MoreGenericRepository.Factories;

public static class Key
{
    public static IKeyWrapper From<TKey>(TKey key) => new KeyWrapper<TKey>(key);
}
