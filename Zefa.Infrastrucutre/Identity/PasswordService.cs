namespace Zefa.Infrastrucutre.Identity;

public class PasswordService : IPasswordService
{
    public string Hash(string password) 
        => BCrypt.Net.BCrypt.HashPassword(password);

    public bool Verify(string password, string passwordHash) 
        => BCrypt.Net.BCrypt.Verify(password, passwordHash);
}