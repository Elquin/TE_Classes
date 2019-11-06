using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Carts
{
    public class CartSqlDao : ICartDao
    {
        private readonly string connectionString;

        public CartSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Cart> GetAllCarts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM carts", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    IList<Cart> cartList = new List<Cart>();
                    while (reader.Read())
                    {
                        cartList.Add(RowToObject(reader));
                    }
                    return cartList;
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

        public void Save(Cart newCart)
        {
            // Implement this method to save cart to database
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO carts (cookie_value, username, created) VALUES (@cookie_value, @username, @created); SELECT @@Identity;", connection);
                    cmd.Parameters.AddWithValue("@cookie_value", newCart.CookieValue);
                    cmd.Parameters.AddWithValue("@username", newCart.Username);
                    cmd.Parameters.AddWithValue("@created", newCart.Created);


                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    newCart.Id = id;
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


        private Cart RowToObject(SqlDataReader reader)
        {
            Cart cart = new Cart();
            cart.Id = Convert.ToInt32(reader["id"]);
            cart.Username = Convert.ToString(reader["username"]);
            cart.CookieValue = Convert.ToString(reader["cookie_value"]);
            cart.Created = Convert.ToDateTime(reader["created"]);
            return cart;

        }


    }
}