using FakeItEasy;
using FluentAssertions;
using Xunit;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurants;

public class ItemSpec
{
    [Fact]
    public void ShouldUpdateName()
    {
        // Arrange
        var item = A.Dummy<Item>();
        var updatedName = "Fish";
 
        // Act
        item.UpdateName(updatedName);
        
        // Assert
        item.Name.Should().Be(updatedName);
    }

    [Fact]
    public void ShouldUpdateDescription()
    {
        // Arrange
        var item = A.Dummy<Item>();
        var updatedDescription = "Fish Baked";
 
        // Act
        item.UpdateDescription(updatedDescription);
        
        // Assert
        item.Description.Should().Be(updatedDescription); 
    }

    [Fact]
    public void ShouldUpdatePrice()
    {
        // Arrange
        var item = A.Dummy<Item>();
        var updatedPrice = 9.5m;
 
        // Act
        item.UpdatePrice(updatedPrice);
        
        // Assert
        item.Price.Should().Be(updatedPrice);
    }

    [Fact]
    public void ShouldBeInvalidPrice()
    {
        // Arrange
        var item = A.Dummy<Item>();
        var updatedPrice = -1.5m;
 
        // Act
        Action act = () => item.UpdatePrice(updatedPrice);
        
        // Assert
        act.Should().ThrowExactly<InvalidItemException>();
    }
}