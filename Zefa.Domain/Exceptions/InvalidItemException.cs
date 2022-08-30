namespace Zefa.Domain.Exceptions;

public class InvalidItemException: BaseDomainException
{
    public InvalidItemException()
    {
    }

    public InvalidItemException(string error)
    {
        this.Error = error;
    }
}