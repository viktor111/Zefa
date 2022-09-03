using Microsoft.EntityFrameworkCore;

namespace Zefa.Infrastrucutre.Persistance;

public class ZefalDbInitializer : IInitializer
{
    private readonly ZefaDbContext _dbContext;

    public ZefalDbInitializer(ZefaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Initialize() => _dbContext.Database.Migrate();
}