using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Zefa.Infrastrucutre;

public static class InfrastructureConfiguration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        return serviceCollection;
    }
    
    public static IServiceCollection AddDataBase(
        this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        return serviceCollection;
    }
    
    public static IServiceCollection AddRepositories(
        this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        return serviceCollection;
    }
    
    
}