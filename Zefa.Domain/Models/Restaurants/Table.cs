using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurants;

public class Table : ValueObject 
{
    public string Name { get; private set; } = default!;

    public bool IsReserved { get; private set; } = default!;

    public int PlacesCount { get; private set; } = default!;
}