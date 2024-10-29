

namespace API.Data;

using API.Entities;

public interface IUserRepository
{
    void Update(AppsUser user);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppsUser>> GetAllAsync();
    Task<AppsUser?> GetByIdAsync(int id);
    Task<AppsUser?> GetByUsernameAsync(string username);
}