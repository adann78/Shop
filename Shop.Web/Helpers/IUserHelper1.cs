using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shop.Web.Data.Entities;

namespace Shop.Web.Helpers
{
    public interface IUserHelper1
    {
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<User> GetUserByEmailAsync(string email);
    }
}