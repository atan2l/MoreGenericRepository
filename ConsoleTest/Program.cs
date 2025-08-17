// See https://aka.ms/new-console-template for more information

using MoreGenericRepository.Abstractions.Wrappers;
using MoreGenericRepository.Entities;
using MoreGenericRepository.Factories;
using MoreGenericRepository.Repositories;

Repository<User> userRepository = new();

userRepository.Add(
    new User
    {
        Id = 1, Name = "John"
    }
);
userRepository.Add(
    new User
    {
        Id = 2, Name = "Jane"
    }
);

IKeyWrapper key  = Key.From(1);
User?       user = userRepository.Find(key);

Console.WriteLine(user?.Name ?? "Not found");
