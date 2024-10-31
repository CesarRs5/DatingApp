

namespace API.Data;

using API.DataEntities;
using API.DTOs;

public interface IUserRepository
{
    void Update(AppsUser user);
    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppsUser>> GetAllAsync();
    Task<AppsUser?> GetByIdAsync(int id);
    Task<AppsUser?> GetByUsernameAsync(string username);
    Task<IEnumerable<MemberResponse>> GetMembersAsync();
    Task<MemberResponse?> GetMemberAsync(string username);
}