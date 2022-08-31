using System.Globalization;
using Bogus;
using FakeItEasy;

namespace Zefa.Domain.Models.Restaurants;

public class ItemFakes
{
    public class ItemDummyFactory: IDummyFactory
    {
        public bool CanCreate(Type type)
        {
            return type == typeof(Item);
        }

        public object? Create(Type type)
        {
            return Data.GetItem();
        }

        public Priority Priority => Priority.Default;
    }

    public static class Data
    {
        public static Item GetItem()
        {
            var faker = new Faker();

            var name = faker.Random.String(10);
            var description = "Fresh chicken on salad";
            var price = decimal.Parse(faker.Commerce.Price(), CultureInfo.InvariantCulture);
            var item = new Faker<Item>()
                .CustomInstantiator(f => new Item(name, description, price))
                .Generate();

            return item;
        }
    }
}