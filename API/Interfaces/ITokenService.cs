namespace API.Interfaces;


using API.DataEntities;

public interface ITokenService
{
    string CreateToken(AppsUser user);
}