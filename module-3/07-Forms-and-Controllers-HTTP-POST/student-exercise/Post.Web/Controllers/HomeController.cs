using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        

        private IReviewDAO reviewDAO;
        public HomeController(IReviewDAO reviewDAO)
        {
            this.reviewDAO = reviewDAO;
        }


        public IActionResult Index()
        {
            IList<Review> reviews = reviewDAO.GetAllReviews();
            return View(reviews);
        }

        [HttpGet]
        public ActionResult Newreview()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Newreview(Review review)
        {
            reviewDAO.SaveReview(review);
            return RedirectToAction("Index");
        }


      

        [HttpPost]
        public IActionResult Save(Review review)
        {
            //Save review using DAO.
            reviewDAO.SaveReview(review);
            //Redirect to the Confirmation page
            return RedirectToAction("ConfirmAdd");

        }

        [HttpGet]
        public IActionResult ConfirmSave()
        {
            return View();
        }

        public IActionResult Summary()
        {
            //Use DAO to retrieve all reviews.
            //Pass IList<Reviews> to view.
            IList<Review> reviews = reviewDAO.GetAllReviews();
            //Return view that takes IList<Reviews>
            return View(reviews);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }

}
