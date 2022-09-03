namespace Zefa.Domain.Exceptions;

public class InvalidPersonalInformationException: BaseDomainException
{
    public InvalidPersonalInformationException()
    {
    }

    public InvalidPersonalInformationException(string error)
    {
        Error = error;
    }
}