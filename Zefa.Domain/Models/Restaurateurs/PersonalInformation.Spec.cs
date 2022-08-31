using FakeItEasy;
using FluentAssertions;
using Xunit;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurateurs;

public class PersonalInformationSpec
{
    [Fact]
    public void ShouldUpdateFirstName()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedName = "Birol";

        //Act
        personalInformation.UpdateFirstName(updatedName);

        //Assert
        personalInformation.FirstName.Should().Be(updatedName);
    }

    [Fact]
    public void ShouldUpdateLastName()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedName = "Birol";

        //Act
        personalInformation.UpdateLastName(updatedName);

        //Assert
        personalInformation.LastName.Should().Be(updatedName); 
    }

    [Fact]
    public void ShouldUpdateEmail()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedEmail = "test1@gmail.com";

        //Act
        personalInformation.UpdateEmail(updatedEmail);

        //Assert
        personalInformation.Email.Should().Be(updatedEmail);  
    }
    
    [Fact]
    public void ShouldUpdatePhoneNumber()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedPhoneNumber = "+359881231231";

        //Act
        personalInformation.UpdatePhoneNumber(updatedPhoneNumber);

        //Assert
        personalInformation.PhoneNumber.Should().Be(updatedPhoneNumber);  
    }
    
    [Fact]
    public void ShouldUpdateBirthDate()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedBirthDate = new DateTime(1988, 1, 3);

        //Act
        personalInformation.UpdateBirthDate(updatedBirthDate);

        //Assert
        personalInformation.BirthDate.Should().Be(updatedBirthDate);  
    }

    [Fact]
    public void ShouldThrowInvalidFirstName()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedName = "B";

        //Act
        Action act = () => personalInformation.UpdateFirstName(updatedName);

        //Assert
        act.Should().ThrowExactly<InvalidPersonalInformationException>();
    }
    
    [Fact]
    public void ShouldThrowInvalidLastName()
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var updatedName = "B";

        //Act
        Action act = () => personalInformation.UpdateFirstName(updatedName);

        //Assert
        act.Should().ThrowExactly<InvalidPersonalInformationException>();
    }
    
    [Theory]
    [InlineData("test^gmail.com")]
    [InlineData("")]
    public void ShouldThrowInvalidEmail(string email)
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();

        //Act
        Action act = () => personalInformation.UpdateEmail(email);

        //Assert
        act.Should().ThrowExactly<InvalidPersonalInformationException>();
    }
    
    [Theory]
    [InlineData("123")]
    [InlineData("")]
    public void ShouldThrowInvalidPhoneNumber(string phoneNumber)
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();

        //Act
        Action act = () => personalInformation.UpdatePhoneNumber(phoneNumber);

        //Assert
        act.Should().ThrowExactly<InvalidPersonalInformationException>();
    }
    
    [Theory]
    [InlineData("1899-1-1")]
    [InlineData("3000-1-1")]
    public void ShouldThrowInvalidBirthDate(string birthDate)
    {
        //Arrange
        var personalInformation = A.Dummy<PersonalInformation>();
        var date = DateTime.Parse(birthDate);

        //Act
        Action act = () => personalInformation.UpdateBirthDate(date);

        //Assert
        act.Should().ThrowExactly<InvalidPersonalInformationException>();
    }
}