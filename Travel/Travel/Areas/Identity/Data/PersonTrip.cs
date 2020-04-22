using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Areas.Identity.Data
{
    public class PersonTrip
    {
        public string TripId  { get; set; }
        public Trip Trip { get; set; }


        public string PersonId { get; set; }
        public Person Person { get; set; }
    }
}
