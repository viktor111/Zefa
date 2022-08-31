using Bogus;
using FakeItEasy;

namespace Zefa.Domain.Models.Restaurateurs;

public class RestaurateurFakes
{
   public class RestaurateurDummyFactory: IDummyFactory
   {
      public bool CanCreate(Type type)
      {
         return type == typeof(PersonalInformation);
      }

      public object? Create(Type type)
      {
         return Data.GetRestaurateur();
      }

      public Priority Priority => Priority.Default;
   }

   public static class Data
   {
      public static Restaurateur GetRestaurateur()
      {
         var personalInformation = A.Dummy<PersonalInformation>();

         var restaurateur = new Faker<Restaurateur>()
            .CustomInstantiator(f => new Restaurateur(personalInformation))
            .Generate();

         return restaurateur;
      }
   }
}