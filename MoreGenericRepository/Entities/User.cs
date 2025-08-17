namespace MoreGenericRepository.Entities;

public class User : BaseEntity<int>
{
    public required string Name { get; set; }
}
