using Bogus;
using FakeItEasy;

namespace Zefa.Domain.Models.Restaurants;

public class RestaurantFakes
{
    public class RestaurantDummyFactory: IDummyFactory
    {
        public bool CanCreate(Type type)
        {
            return type == typeof(Restaurant);
        }

        public object? Create(Type type)
        {
            return Data.GetRestaurant();
        }

        public Priority Priority => Priority.Default;
    }

    public static class Data
    {
        public static Restaurant GetRestaurant()
        {
            var faker = new Faker();

            var name = faker.Commerce.ProductName();
            var address = faker.Address.FullAddress();

            var restaurant = new Faker<Restaurant>()
                .CustomInstantiator(f => new Restaurant(name, address))
                .Generate();

            return restaurant;
        }
    }
}