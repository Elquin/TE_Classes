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
                    IList<Post> postList = new IList<Post>();
                    while (reader.Read())
                    {
                        postList.Add(RowToObject(reader));
                        return null;
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


        //public void Save(Post newPost)
        //{

        //    try
        //    {

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();
        //            SqlCommand cmd = new SqlCommand("INSERT INTO posts", connection);
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            IList<Post> postList = new IList<Post>();
        //            while (reader.Read())
        //            {
        //                postList.Add(RowToObject(reader));
        //                return null;
        //            }
        //            return postList;

        //        }

        //    }
        //    catch (SqlException)
        //    {
        //        throw;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    // Implement this method to save post to database
        //}



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