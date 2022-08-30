using Zefa.Domain.Common;

namespace Zefa.Domain.Models.Restaurateurs;

public class PersonalInformation : ValueObject
{
    public string FirstName { get; private set; } = default!;

    public string LastName { get; private set; } = default!;

    public string Email { get; private set; } = default!;

    public string PhoneNumber { get; private set; } = default!;

    public DateTime BirthDate { get; private set; } = default!;
}