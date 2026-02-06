using SecurityApp.Core.Entities;

namespace SecurityApp.Core.Interfaces
{
    public interface IAuthService
    {
        Task<AppUser?> LoginAsync(string username, string password);
    }
}