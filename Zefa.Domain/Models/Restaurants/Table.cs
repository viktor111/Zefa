using Zefa.Domain.Common;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurants;

public class Table : ValueObject 
{
    internal Table(string name, bool isReserved, int placesCount)
    {
        Validate(name, placesCount);

        Name = name;
        IsReserved = isReserved;
        PlacesCount = placesCount;
    }
    
    public string Name { get; private set; } = default!;

    public bool IsReserved { get; private set; } = default!;

    public int PlacesCount { get; private set; } = default!;

    public void UpdateName(string name)
    {
        ValidateName(name);
        Name = name;
    }

    public void UpdateIsReserved(bool isReserved)
    {
        IsReserved = isReserved;
    }

    public void UpdatePlacesCount(int placesCount)
    {
        this.ValidatePlacesCount(placesCount);
        PlacesCount = placesCount;
    }

    private void ValidateName(string name)
    {
        Guard.AgainstEmptyString<InvalidTableException>(name, nameof(name));
        Guard.ForStringLength<InvalidTableException>(
            name,
            ModelConstants.Table.MinNameLength,
            ModelConstants.Table.MaxNameLength,
            nameof(name)); 
    }

    public void ValidatePlacesCount(int placesCount)
    {
        Guard.AgainstOutOfRange<InvalidTableException>(
            placesCount,
            ModelConstants.Table.MinPlacesCountLength,
            ModelConstants.Table.MaxPlacesCountLength,
            nameof(placesCount));
    }

    public void Validate(string name, int placesCount)
    {
        ValidateName(name);
        ValidatePlacesCount(placesCount);
    }
}