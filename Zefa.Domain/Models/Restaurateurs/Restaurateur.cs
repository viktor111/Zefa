using Zefa.Domain.Common;
using Zefa.Domain.Models.Restaurants;

namespace Zefa.Domain.Models.Restaurateurs;

public class Restaurateur : Entity<Guid>, IAggregateRoot
{
    private HashSet<Restaurant> restaurants;

    public Restaurateur(PersonalInformation personalInformation)
    {
        PersonalInformation = personalInformation;
        restaurants = new HashSet<Restaurant>();
    }
    public PersonalInformation PersonalInformation { get; private set; } = default!;
}