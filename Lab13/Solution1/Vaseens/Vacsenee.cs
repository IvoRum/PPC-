using System.Text.RegularExpressions;

namespace Vaseens;

public class Vacsenee
{
    public bool CheckUsername(string username)
    {
        Regex usernameRegex = new Regex("^[a-z][a-z0-9]{4,7}$");
        return usernameRegex.IsMatch(username);
    }
    
    public bool CheckPassword(string password)
    {
        Regex passwordRegex = new Regex("^[a-z][a-z0-9]{2,3}\\?$");
        return passwordRegex.IsMatch(password);
    }
}