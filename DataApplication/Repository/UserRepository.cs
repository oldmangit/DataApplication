using DataApplication.Data;
using DataApplication.Models;
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
                string query = "select * from employees limit 100;";

                using (var command = new MySqlCommand(query, connection))
                {
                    var result =await command.ExecuteReaderAsync();
                    table.Load(result);
                    return table;
                }
            }
        }
        public async Task<bool> RegisterUserAsync(string username,string user_role,string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            using (var connection = await _factory.createConnectionAsync())
            {
                string query = "insert into users(username,password,role) values(@username,@password,@role);";
                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);
                command.Parameters.AddWithValue("@role", user_role);

                int result =await command.ExecuteNonQueryAsync();

                if (result > 0)
                    return true;
                else
                    return false;
            }

        }
        public async Task<bool> LoginUserAsync(string username , string password)
        {
            using (var connection = await _factory.createConnectionAsync())
            {
                string query = "select password from users where username=@username;";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                var result = await command.ExecuteScalarAsync();

                if (result == null) return false;
                string? storedHash = result.ToString()?? "";

                return BCrypt.Net.BCrypt.Verify(password, storedHash);
                //return (password == storedHash);
            }
        }

        public async Task<User?> GetUserAsync(string username)
        {
            User user = null;
            string query = "select * from users where username = @username;";
            using (var connection = await _factory.createConnectionAsync())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                Role = reader["role"].ToString(),
                                Is_active = Convert.ToBoolean(reader["is_active"]),
                                Is_deleted = Convert.ToBoolean(reader["is_deleted"])
                            };
                        }
                    }
                }
            }
            return user;
        }
    }
}
