namespace Zefa.Domain.Exceptions;

public class InvalidTableException: BaseDomainException
{
    public InvalidTableException()
    {
    }

    public InvalidTableException(string error)
    {
        this.Error = error;
    }
}