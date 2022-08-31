using FakeItEasy;
using FluentAssertions;
using Xunit;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurants;

public class RestaurantSpec
{
   [Fact]
   public void ShouldUpdateName()
   {
      // Arrange
      var restaurant = A.Dummy<Restaurant>();
      var updatedName = "Subway";
 
      // Act
      restaurant.UpdateName(updatedName);
      
      // Assert
      restaurant.Name.Should().Be(updatedName);
   }

   [Fact]
   public void ShouldUpdateAddress()
   {
      // Arrange
      var restaurant = A.Dummy<Restaurant>();
      var updatedAddress = "bul. New City 106";
      
      // Act
      restaurant.UpdateAddress(updatedAddress);
      
      // Assert
      restaurant.Address.Should().Be(updatedAddress); 
   }

   [Fact]
   public void ShouldAddMenuItem()
   {
      // Arrange
      var restaurant = A.Dummy<Restaurant>();
      var item = A.Dummy<Item>();
      
      // Act
      restaurant.AddMenuItem(item);
      
      // Assert
      restaurant.Menu.FirstOrDefault().Should().Be(item);
   }

   [Fact]
   public void ShouldAddTable()
   {
      // Arrange
      var restaurant = A.Dummy<Restaurant>();
      var table = A.Dummy<Table>();
      
      // Act
      restaurant.AddTable(table);
      
      // Assert
      restaurant.Tables.FirstOrDefault().Should().Be(table);
   }
}