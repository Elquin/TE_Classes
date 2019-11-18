using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Puppies.Web.DAL;
using Puppies.Web.Models;

namespace Puppies.Web.Controllers
{
    public class PuppiesController : Controller
    {
        private IPuppyDao puppyDao;

        public PuppiesController(IPuppyDao puppyDao)
        {
            this.puppyDao = puppyDao;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<Puppy> puppies = puppyDao.GetPuppies();
            return View(puppies);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            Puppy puppy = puppyDao.GetPuppy(id);

            if (puppy == null)
            {
                return NotFound();
            }
            return View(puppy);
        }


        [HttpPost]
        public IActionResult Save(Puppy puppy)
        {
            puppyDao.SavePuppy(puppy);
            return RedirectToAction("Index");
        }

    }
}
