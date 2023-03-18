namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string firstName, string LastName, string email, string password)
    {
        // return new AuthenticationResult with this params
        
    }

    public AuthenticationResult Register(string email, string password)
    {
        throw new NotImplementedException();
    }
}