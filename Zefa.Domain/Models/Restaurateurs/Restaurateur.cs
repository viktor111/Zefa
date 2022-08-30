using Zefa.Domain.Common;
using Zefa.Domain.Models.Restaurants;

namespace Zefa.Domain.Models.Restaurateurs;

public class Restaurateur : Entity<Guid>, IAggregateRoot
{
    public PersonalInformation PersonalInformation { get; private set; } = default!;

    public HashSet<Restaurant> Restaurants { get; private set; } = default!;
}