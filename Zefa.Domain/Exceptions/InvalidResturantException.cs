namespace Zefa.Domain.Exceptions;

public class InvalidResturantException: BaseDomainException
{
    public InvalidResturantException()
    {
    }

    public InvalidResturantException(string error)
    {
        this.Error = error;
    }
}