using API.Entities;

namespace API.Token;

public interface ITokenService
{
    string CreateToken(AppUser user);
}

