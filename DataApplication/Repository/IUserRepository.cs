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
    }
}
