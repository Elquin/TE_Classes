using GETForms.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.DAL
{
    public class CustomerDAO : ICustomerDAO
    {
        private string connectionString;

        public CustomerDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Searches for customers.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public IList<Customer> SearchForCustomers(string search, string sortBy)
        {
            IList<Customer> customers = new List<Customer>();

            string cmdString;
            if(sortBy == "Last Name")
            {
                cmdString = "SELECT first_name, last_name, email, active FROM customer WHERE last_name LIKE @search OR first_name LIKE @search ORDER BY last_name";
            }
            else if(sortBy == "Email")
            {
                cmdString = "SELECT first_name, last_name, email, active FROM customer WHERE last_name LIKE @search OR first_name LIKE @search ORDER BY email";
            }
            else
            {
                cmdString = "SELECT first_name, last_name, email, active FROM customer WHERE last_name LIKE @search OR first_name LIKE @search ORDER BY active";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdString, conn);
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customers.Add(MapRowToCustomer(reader));
                }
            }
            return customers;
        }


        /// <summary>
        /// Maps a sql data row to an customer object.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"])
            };
        }

    }
}
