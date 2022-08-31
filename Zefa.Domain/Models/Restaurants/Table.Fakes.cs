using Bogus;
using FakeItEasy;

namespace Zefa.Domain.Models.Restaurants;

public class TableFakes
{
    public class TableDummyFactory: IDummyFactory
    {
        public bool CanCreate(Type type)
        {
            return type == typeof(Table);
        }

        public object? Create(Type type)
        {
            return Data.GetTable();
        }

        public Priority Priority => Priority.Default;
    }

    public static class Data
    {
        public static Table GetTable()
        {
            var faker = new Faker();

            var name = faker.Random.String(9);
            var isReserved = false; 
            var placesCount = faker.Random.Int(1, 9);

            var table = new Faker<Table>()
                .CustomInstantiator(f => new Table(name, isReserved, placesCount))
                .Generate();

            return table;
        }
    }
}