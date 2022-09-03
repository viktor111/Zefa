using Zefa.Domain.Exceptions;
using Zefa.Domain.Models.Restaurateurs;

namespace Zefa.Infrastrucutre.Identity;

public class User 
{
   public Guid Id { get; set; }
   
   public string UserName { get; set; }
   
   public Restaurateur? Restaurateur { get; set; }

   public void BecomeRestaurateur(Restaurateur restaurateur)
   {
      if (Restaurateur is null)
      {
         throw new InvalidRestaurateurException($"User ${UserName} is already a restaurateur");
      }

      Restaurateur = restaurateur;
   } 
}