using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurateurs;

public class PersonalInformation : ValueObject
{
    public string FirstName { get; } = default!;

    public string LastName { get; } = default!;

    public string Email { get; } = default!;

    public string PhoneNumber { get; } = default!;

    public DateTime BirthDate { get; } = default!;
}