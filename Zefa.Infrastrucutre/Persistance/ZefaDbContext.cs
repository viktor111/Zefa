using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Zefa.Domain.Models.Restaurants;
using Zefa.Domain.Models.Restaurateurs;
using Zefa.Infrastrucutre.Identity;

namespace Zefa.Infrastrucutre.Persistance;

public class ZefaDbContext : DbContext 
{
    public ZefaDbContext(DbContextOptions<ZefaDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Restaurateur> Restaurateurs { get; set; }
    
    public DbSet<Restaurant> Restaurants { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}