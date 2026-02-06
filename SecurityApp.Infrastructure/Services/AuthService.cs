using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecurityApp.Core.Entities;
using SecurityApp.Core.Interfaces;
using SecurityApp.Infrastructure.Data;

namespace SecurityApp.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly IPasswordHasher<AppUser> _passwordHasher;

        public AuthService(AppDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<AppUser>();
        }

        public async Task<AppUser?> LoginAsync(string username, string password)
        {
            var user = await _context.Users
                .Include(u => u.Building)
                .FirstOrDefaultAsync(u => u.UserName == username);

            if (user == null)
            {
                return null; 
            }
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);

            if (result == PasswordVerificationResult.Failed)
            {
                return null;
            }
            return user;
        }
    }
}