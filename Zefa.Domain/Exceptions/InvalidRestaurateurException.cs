namespace Zefa.Domain.Exceptions;

public class InvalidRestaurateurException: BaseDomainException
{
    public InvalidRestaurateurException()
    {
    }

    public InvalidRestaurateurException(string error)
    {
        Error = error;
    }
}