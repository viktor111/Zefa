using Zefa.Domain.Common;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurants;

public class Item : ValueObject
{
    internal Item(string name, string description, decimal price)
    {
        Validate(name, description, price);
        
        Name = name;
        Description = description;
        Price = price;
    }

    private Item()
    {
    }

    public string Name { get; private set; } = default!;

    public string Description { get; private set; } = default!;

    public decimal Price { get; private set; } = default!;

    public void UpdateName(string name)
    {
        ValidateName(name);
        Name = name;
    }

    public void UpdateDescription(string description)
    {
        ValidateDescription(description);
        Description = description;
    }

    public void UpdatePrice(decimal price)
    {
        ValidatePrice(price);
        Price = price;
    }

    private void ValidateName(string name)
    {
        Guard.AgainstEmptyString<InvalidItemException>(name, nameof(name));
        Guard.ForStringLength<InvalidItemException>(
            name,
            ModelConstants.Item.MinNameLength,
            ModelConstants.Item.MaxNameLength,
            nameof(name));
    }

    private void ValidateDescription(string description)
    {
        Guard.AgainstEmptyString<InvalidItemException>(description, nameof(description));
        Guard.ForStringLength<InvalidItemException>(
            description,
            ModelConstants.Item.MinDescriptionLength,
            ModelConstants.Item.MaxDescriptionLength,
            nameof(description));
    }

    private void ValidatePrice(decimal price)
    {
        Guard.AgainstOutOfRange<InvalidItemException>(
            price,
            ModelConstants.Item.MinPriceValue,
            decimal.MaxValue,
            nameof(price));
    }

    private void Validate(string name, string description, decimal price)
    {
        ValidateName(name);
        ValidateDescription(description);
        ValidatePrice(price);
    }
}