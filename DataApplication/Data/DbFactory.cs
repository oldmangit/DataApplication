using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication.Data
{
    public class DbFactory
    {
        private readonly string _connectionString;
        public DbFactory(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("defaultConnection") ??
                                    throw new Exception("Connection string not found!");
        }
        public async Task<MySqlConnection> createConnectionAsync()
        {
            var connection = new MySqlConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}
