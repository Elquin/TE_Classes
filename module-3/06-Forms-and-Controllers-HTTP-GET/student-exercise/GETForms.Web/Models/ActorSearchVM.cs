using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class ActorSearchVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Actor> Actors { get; set; }
    }
}
