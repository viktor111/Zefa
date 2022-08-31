using FakeItEasy;
using FluentAssertions;
using Xunit;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurants;

public class TableSpec
{
    [Fact]
    public void ShouldUpdateName()
    {
        // Arrange
        var table = A.Dummy<Table>();
        var updatedName = "A1";
 
        // Act
        table.UpdateName(updatedName);
        
        // Assert
        table.Name.Should().Be(updatedName);
    }

    [Fact]
    public void ShouldUpdateIsReserved()
    {
        // Arrange
        var table = A.Dummy<Table>();
        var updatedIsReserved = true;

        // Act
        table.UpdateIsReserved(updatedIsReserved);
        
        // Assert
        table.IsReserved.Should().Be(updatedIsReserved);
    }

    [Fact]
    public void ShouldUpdatePlacesCount()
    {
        // Arrange
        var table = A.Dummy<Table>();
        var updatedPlacesCount = 4;

        // Act
        table.UpdatePlacesCount(updatedPlacesCount);
        
        // Assert
        table.PlacesCount.Should().Be(updatedPlacesCount);
    }

    [Theory]
    [InlineData(11)]
    [InlineData(0)]
    public void ShouldThrowInvalidPlacesCount(int updatedPlacesCount)
    {
        // Arrange
        var table = A.Dummy<Table>();
        
        // Act
        Action act = () => table.UpdatePlacesCount(updatedPlacesCount);
        
        // Assert
        act.Should().ThrowExactly<InvalidTableException>();
    }
}