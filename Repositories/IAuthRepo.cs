using MyPortfolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolioAPI.Repositories
{
    public interface IAuthRepo
    {
        Task<User> Register(User user, string pasasword);
        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);
    }
}
