using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductReviewsAPI.Models;
using ProductReviewsAPI.Services;

namespace ProductReviewsAPI.Controllers
{
    [Route("api/reviews")] //Our API is found at http://localhost:xyz/api/reviews
    [ApiController]
    public class ProductReviewsController : ControllerBase
    {

        private DataAccessObject dao;

        public ProductReviewsController(DataAccessObject dao)
        {
            this.dao = dao;
        }

        /// <summary>
        /// Returns all product reviews.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<ProductReview>> GetAll()
        {
            List<ProductReview> reviews = dao.GetAll();
            return Ok(reviews);
        }

        [HttpGet("{id}", Name = "GetReviewById")]
        public ActionResult<ProductReview> GetReviewById(int id)
        {
            ProductReview review = dao.Get(id);

            if (review == null)
            {
                return NotFound();
            }

            return Ok(review);
        }
        /// <summary>
        /// Deletes a product review.
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ProductReview review = dao.Get(id);

            if (review == null)
            {
                return NotFound();
            }

            dao.Delete(id);
            return NoContent();
        }

        [HttpPost]
        public ActionResult<ProductReview> CreateNewReview([FromBody]ProductReview productReview)
        {
            // Save in the dao
            dao.Add(productReview);

            // Return 201 (with a location header: https://localhost:44359/api/reviews/{id})
            // First parameter - Name of the route to generate for API
            // Second parameter - The variables for the route. It expects an object. We can cover this syntax tomorrow if it is new.
            // Third parameter - The response body
            return CreatedAtRoute("GetReviewById", new { id = productReview.Id }, productReview);
        }


        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody]ProductReview productReview)
        {
            ProductReview existingReview = dao.Get(id);
            if(existingReview == null)
            {
                return NotFound();
            }

            //Copy over the fields we want to update
            existingReview.Name = productReview.Name;
            existingReview.Title = productReview.Title;
            existingReview.Review = productReview.Review;

            //Save existing review back
            dao.Update(existingReview);

            return NoContent();

        }

    }
}