using Bogus;
using FakeItEasy;

namespace Zefa.Domain.Models.Restaurateurs;

public class PersonalInformationFakes
{
    public class PersonalInformationDummyFactory : IDummyFactory
    {
        public bool CanCreate(Type type)
        {
            return type == typeof(PersonalInformation);
        }

        public object? Create(Type type)
        {
            return Data.GetPersonalInformation();
        }

        public Priority Priority => Priority.Default;
    }

    private static class Data
    {
        public static PersonalInformation GetPersonalInformation()
        {
            var faker = new Faker();
            
            var firstName = faker.Random.String(10);
            var lastName = faker.Random.String(10);
            var email = "tes@asd.com";
            var phoneNumber = "+359123456789";
            var birthDate = faker.Person.DateOfBirth;

                var personalInformation = new Faker<PersonalInformation>()
                .CustomInstantiator(f => new PersonalInformation(
                    firstName,
                    lastName, 
                    email, 
                    phoneNumber,
                    birthDate))
                .Generate();

            return personalInformation;
        }
    }
}