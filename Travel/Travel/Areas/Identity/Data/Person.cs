using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Travel.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Person class
    public class Person : IdentityUser
    {

        [MaxLength(100)]
        public string FirstName { get; set; }
        
        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string Gender { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public List<Trip> Trips { get; set; }
    }
}
