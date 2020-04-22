using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Areas.Identity.Data
{
    public class Trip
    {

        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string ShortDescription { get; set; }

        public string PictureLocation { get; set; }


        [MaxLength(200)]
        public string Country { get; set; }

        [MaxLength(200)]
        public string City { get; set; }

        [MaxLength(50)]
        public DateTime Date { get; set; }

        public string Details { get; set; }

        public decimal Price { get; set; }

        public List<PersonTrip> PersonTrips { get; set; }

    }
}
