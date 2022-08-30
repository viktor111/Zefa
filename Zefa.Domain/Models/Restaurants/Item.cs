using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurants;

public class Item : Entity<Guid>
{
    public string Name { get; } = default!;

    public string Description { get; } = default!;

    public decimal Price { get; } = default!;
}