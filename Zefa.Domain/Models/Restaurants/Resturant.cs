using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurants;

public class Restaurant : Entity<Guid>, IAggregateRoot
{
    public string Name { get; private set; } = default!;

    public string Address { get; private set; } = default!;

    public HashSet<Item> Menu { get; private set;} = default!;

    public HashSet<Table> Tables { get; private set;} = default!;
}