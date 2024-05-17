using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Travel.Areas.Identity.Data;

namespace Travel.Data
{
    public class TravelContext : IdentityDbContext<Person>
    {
        public DbSet<PersonTrip> PeopleTrips { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

           builder.Entity<PersonTrip>().HasKey(x => new{ x.TripId , x.PersonId });
                
            builder.Entity<PersonTrip>()
                .HasOne(x => x.Person)
                .WithMany(y => y.PersonTrips)
                .HasForeignKey(x => x.PersonId);

            builder.Entity<PersonTrip>()
                .HasOne(x => x.Trip)
                .WithMany(b => b.PersonTrips)
                .HasForeignKey(x => x.TripId);

        }


    }
}
