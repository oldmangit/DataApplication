using DataApplication.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Repository
{
    
    public class UserRepository :IUserRepository
    {
        private readonly DbFactory _factory;
        public UserRepository(DbFactory factory)
        {
            _factory = factory;
        }

        public async Task<DataTable> LoadAllAsync()
        {
            var table = new DataTable();
            using (var connection =await _factory.createConnectionAsync())
            {


                string query = "select * from employees limit 10;";

                using (var command = new MySqlCommand(query, connection))
                {
                    var result =await command.ExecuteReaderAsync();
                    table.Load(result);
                    return table;
                }
            }
        }
    }
}
