using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Posts
{
    public class UserSqlDao : IUserDao
    {
        private readonly string connectionString;

        public UserSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<User> GetAllUsers()
        {
            // Implement this method to pull in all users from database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM users", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    IList<User> userList = new List<User>();
                    while (reader.Read())
                    {
                        userList.Add(RowToObject(reader));
                    }
                    return userList;
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Save(User newUser)
        {
            // Implement this method to save user to database

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO users (first_name, last_name, email, role, created) VALUES (@first_name, @last_name, @email, @role, @created); SELECT @@Identity;", connection);
                    cmd.Parameters.AddWithValue("@first_name", newUser.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", newUser.LastName);
                    cmd.Parameters.AddWithValue("@email", newUser.Email);
                    cmd.Parameters.AddWithValue("@role", newUser.Role);
                    cmd.Parameters.AddWithValue("@created", newUser.Created);

                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    newUser.Id = id;
                }

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private User RowToObject(SqlDataReader reader)
        {
            User user = new User();
            user.FirstName = Convert.ToString(reader["first_name"]);
            user.LastName = Convert.ToString(reader["last_name"]);
            user.Email = Convert.ToString(reader["email"]);
            user.Role = Convert.ToString(reader["role"]);
            user.Created = Convert.ToDateTime(reader["created"]);

            return user;
        }
    }
}

