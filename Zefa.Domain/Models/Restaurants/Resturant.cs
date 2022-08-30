using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurants;

public class Restaurant : Entity<Guid>, IAggregateRoot
{
    public string Name { get; } = default!;

    public string Address { get; } = default!;

    public HashSet<Item> Menu { get; } = default!;

    public HashSet<Table> Tables { get; } = default!;
}