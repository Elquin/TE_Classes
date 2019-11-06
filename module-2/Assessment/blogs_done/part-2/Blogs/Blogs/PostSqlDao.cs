using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public IList<Post> GetAllPosts()
        {
            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM posts", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    IList<Post> postList = new List<Post>();
                    while (reader.Read())
                    {
                        postList.Add(RowToObject(reader));
                    }
                    return postList;

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


        public void Save(Post newPost)
        {

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO posts (body, created, published, name) VALUES (@body, @created, @published, @name); SELECT @@Identity;", connection);
                    cmd.Parameters.AddWithValue("@body", newPost.Body);
                    cmd.Parameters.AddWithValue("@created", newPost.Created);
                    cmd.Parameters.AddWithValue("@published", newPost.IsPublished);
                    cmd.Parameters.AddWithValue("@name", newPost.Name);


                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    newPost.Id = id;
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
            // Implement this method to save post to database
        }



        private Post RowToObject(SqlDataReader reader)
        {
            Post post = new Post();
            post.Body = Convert.ToString(reader["body"]);
            post.Created = Convert.ToDateTime(reader["created"]);
            post.Id = Convert.ToInt32(reader["id"]);
            post.IsPublished = Convert.ToBoolean(reader["published"]);
            post.Name = Convert.ToString(reader["name"]);
            return post;

        }
    }
}