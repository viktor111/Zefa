namespace Zefa.Infrastrucutre.Identity;

public interface IJwtService
{
   public string GenerateToken(User user);
}