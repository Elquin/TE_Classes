using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Communities
{
    public class CommunitySqlDao : ICommunityDao
    {
        private readonly string connectionString;

        public CommunitySqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Community> GetAllCommunities()
        {
            // Implement this method to pull in all communities from database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM communities", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    IList<Community> communityList = new List<Community>();
                    while (reader.Read())
                    {
                        communityList.Add(RowToObject(reader));
                    }
                    return communityList;
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

        public void Save(Community newCommunity)
        {
            // Implement this method to save community to database
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO communities (name, latitude, longitude, created, live) VALUES (@name, @latitude, @longitude, @created, @live); SELECT @@Identity;", connection);
                    cmd.Parameters.AddWithValue("@name", newCommunity.Name);
                    cmd.Parameters.AddWithValue("@latitude", newCommunity.Latitude);
                    cmd.Parameters.AddWithValue("@longitude", newCommunity.Longitude);
                    cmd.Parameters.AddWithValue("@created", newCommunity.Created);
                    cmd.Parameters.AddWithValue("@live", newCommunity.IsLive);
                    
                    

                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    newCommunity.Id = id;
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


        private Community RowToObject(SqlDataReader reader)
        {
            Community community = new Community();
            community.Id = Convert.ToInt32(reader["id"]);
            community.IsLive = Convert.ToBoolean(reader["live"]);
            community.Latitude = Convert.ToDecimal(reader["latitude"]);
            community.Longitude = Convert.ToDecimal(reader["longitude"]);
            community.Name = Convert.ToString(reader["name"]);
            community.Created = Convert.ToDateTime(reader["created"]);
            return community;
        }


    }
}
