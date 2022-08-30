using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurants;

public class Table : Entity<Guid>
{
    public string Name { get; } = default!;

    public bool IsReserved { get; } = default!;

    public int PlacesCount { get; } = default!;
}