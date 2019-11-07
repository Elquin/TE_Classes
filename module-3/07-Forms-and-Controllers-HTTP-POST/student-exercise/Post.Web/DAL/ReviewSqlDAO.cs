using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>
        public IList<Review> GetAllReviews()
        {
            IList<Review> review = new List<Review>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM reviews", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    review.Add(MapRowToReview(reader));
                }
            }

            return review;
        }

           


        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO reviews (username, rating, review_title, review_text, review_date) VALUES (@username, @rating, @reviewTitle, @reviewText, GetDate()); Select @@Identity;", conn);
                    cmd.Parameters.AddWithValue("@username", newReview.UserName);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@reviewTitle", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@reviewText", newReview.ReviewText);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        private Review MapRowToReview(SqlDataReader reader)
        {
            return new Review()
            {
                UserName = Convert.ToString(reader["username"]),
                Rating = Convert.ToInt32(reader["rating"]),
                ReviewTitle = Convert.ToString(reader["review_title"]),
                ReviewText = Convert.ToString(reader["review_text"]),
                ReviewDate = Convert.ToDateTime(reader["review_date"]),
            };
        }




    }
}
