using Zefa.Domain.Common;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurateurs;

public class PersonalInformation : ValueObject
{
    internal PersonalInformation(
        string firstName,
        string lastName,
        string email,
        string phoneNumber, 
        DateTime birthDate)
    {
        Validate(
            firstName,
            lastName,
            email,
            phoneNumber,
            birthDate);
        
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        BirthDate = birthDate;
    }

    private PersonalInformation()
    {
    }
    
    public string FirstName { get; private set; } = default!;

    public string LastName { get; private set; } = default!;

    public string Email { get; private set; } = default!;

    public string PhoneNumber { get; private set; } = default!;

    public DateTime BirthDate { get; private set; } = default!;

    public void UpdateFirstName(string firstName)
    {
        ValidateFirstName(firstName);
        FirstName = firstName;
    }

    public void UpdateLastName(string lastName)
    {
        ValidateLastName(lastName);
        LastName = lastName;
    }

    public void UpdateEmail(string email)
    {
        ValidateEmail(email);
        Email = email;
    }

    public void UpdatePhoneNumber(string phoneNumber)
    {
        ValidatePhoneNumber(phoneNumber);
        PhoneNumber = phoneNumber;
    }

    public void UpdateBirthDate(DateTime birthDate)
    {
        ValidateBirthDate(birthDate);
        BirthDate = birthDate;
    }
    
    private void ValidateFirstName(string firstName)
    {
        Guard.AgainstEmptyString<InvalidPersonalInformationException>(firstName, nameof(firstName));
        Guard.ForStringLength<InvalidPersonalInformationException>(
            firstName,
            ModelConstants.PersonalInformation.MinFirstNameLength,
            ModelConstants.PersonalInformation.MaxFirstNameLength,
            nameof(firstName));
    }

    private void ValidateLastName(string lastName)
    {
        Guard.AgainstEmptyString<InvalidPersonalInformationException>(lastName, nameof(lastName));
        Guard.ForStringLength<InvalidPersonalInformationException>(
            lastName,
            ModelConstants.PersonalInformation.MinLastNameLength,
            ModelConstants.PersonalInformation.MaxLastNameLength,
            nameof(lastName)); 
    }

    private void ValidateEmail(string email)
    {
        Guard.AgainstEmptyString<InvalidPersonalInformationException>(email, email);
        Guard.ForStringLength<InvalidPersonalInformationException>(
            email,
            ModelConstants.PersonalInformation.MinEmailLength,
            ModelConstants.PersonalInformation.MaxEmailLength,
            nameof(email));  
        Guard.AgainstRegex<InvalidPersonalInformationException>(
            email,
            ModelConstants.PersonalInformation.EmailRegex,
            nameof(email));
    }

    private void ValidatePhoneNumber(string phoneNumber)
    {
        Guard.AgainstEmptyString<InvalidPersonalInformationException>(phoneNumber, nameof(phoneNumber));
        Guard.ForStringLength<InvalidPersonalInformationException>(
            phoneNumber,
            ModelConstants.PersonalInformation.MinPhoneNumberLength,
            ModelConstants.PersonalInformation.MaxPhoneNumberLength,
            nameof(phoneNumber)); 
        Guard.AgainstRegex<InvalidPersonalInformationException>(
            phoneNumber, 
            ModelConstants.PersonalInformation.PhoneNumberRegex,
            nameof(phoneNumber));
    }

    private void ValidateBirthDate(DateTime birthDate)
    {
        Guard.AgainstDateRange<InvalidPersonalInformationException>(
            birthDate,
            ModelConstants.PersonalInformation.MinBirthDate, 
            ModelConstants.PersonalInformation.MaxBirthDate, 
            nameof(birthDate));
    }

    private void Validate(
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        DateTime birthDate)
    {
        ValidateFirstName(firstName);
        ValidateLastName(lastName);
        ValidateEmail(email);
        ValidatePhoneNumber(phoneNumber);
        ValidateBirthDate(birthDate);
    }
}