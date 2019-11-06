using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {

        private ICustomerDAO customerDAO;
        public CustomersController(ICustomerDAO customerDao)
        {
            this.customerDAO = customerDao;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// The request to display search results.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(string search, string sortBy)
        {
            /* Call the DAL and pass the values as a model back to the View */
            return View(customerDAO.SearchForCustomers(search, sortBy));
        }

    }
}