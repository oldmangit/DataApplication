using DataApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Repository
{
    public interface IUserRepository
    {
        Task<DataTable> LoadAllAsync();
        Task<bool> RegisterUserAsync(string username, string user_role, string password);
        Task<bool> LoginUserAsync(string username, string password);
        Task<User?> GetUserAsync(string username);
    }
}
