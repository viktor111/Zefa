using Zefa.Domain.Common;
using Zefa.Domain.Models.Restaurants;

namespace Zefa.Domain.Models.Restaurateurs;

public class Restaurateur : Entity<Guid>, IAggregateRoot
{
    public PersonalInformation PersonalInformation { get; } = default!;

    public HashSet<Restaurant> Restaurants { get; } = default!;
}