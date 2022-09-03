using Zefa.Domain.Common;
using Zefa.Domain.Exceptions;

namespace Zefa.Domain.Models.Restaurants;

public class Restaurant : Entity<Guid>, IAggregateRoot
{
    private HashSet<Item> menu;

    private HashSet<Table> tables;

    public Restaurant(string name, string address)
    {
        Validate(name, address);
        
        Name = name;
        Address = address;
        menu = new HashSet<Item>();
        tables = new HashSet<Table>();
    }

    public string Name { get; private set; } = default!;

    public string Address { get; private set; } = default!;

    public IReadOnlyCollection<Item> Menu => menu.ToList().AsReadOnly();

    public IReadOnlyCollection<Table> Tables => tables.ToList().AsReadOnly();

    public void UpdateName(string name)
    {
        ValidateName(name);
        Name = name;
    }

    public void UpdateAddress(string address)
    {
        ValidateAddress(address);
        Address = address;
    }
    
    public void AddMenuItem(Item item)
    {
        menu.Add(item);
    }

    public void AddTable(Table table)
    {
        tables.Add(table);
    }
    
    private void ValidateName(string name)
    {
        Guard.AgainstEmptyString<InvalidRestaurateurException>(name, nameof(name));
        Guard.ForStringLength<InvalidRestaurateurException>(
            name,
            ModelConstants.Restaurant.MinNameLength,
            ModelConstants.Restaurant.MaxNameLength,
            nameof(name));
    }

    private void ValidateAddress(string address)
    {
        Guard.AgainstEmptyString<InvalidRestaurateurException>(address, nameof(address));
        Guard.ForStringLength<InvalidRestaurateurException>(
            address,
            ModelConstants.Restaurant.MinAddressLength,
            ModelConstants.Restaurant.MaxAddressLength,
            nameof(address)); 
    }

    private void Validate(string name, string address)
    {
        ValidateName(name);
        ValidateAddress(address);
    }
}