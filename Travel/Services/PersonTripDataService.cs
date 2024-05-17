using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Areas.Identity.Data;
using Travel.Data;
using Travel.Interfaces;

namespace Travel.Services
{
    public class PersonTripDataService : IPersonTripDataService
    {
        private readonly TravelContext travelContext;

        public PersonTripDataService(TravelContext travelContext)
        {
            this.travelContext = travelContext;
        }

        public async Task AddPersonTrip(Person person, Trip trip)
        {
            PersonTrip personTrip = new PersonTrip();
            
            personTrip.PersonId = person.Id;
            personTrip.Person = person;

            personTrip.TripId = trip.Id;
            personTrip.Trip = trip;

            if (person.PersonTrips != null)
            {
                person.PersonTrips.Add(personTrip);
            }
            else
            {
                person.PersonTrips = new List<PersonTrip>();
                person.PersonTrips.Add(personTrip);

            }

            if (trip.PersonTrips != null)
            {
                trip.PersonTrips.Add(personTrip);
            }
            else
            {
                trip.PersonTrips = new List<PersonTrip>();
                trip.PersonTrips.Add(personTrip);

            }
            await travelContext.SaveChangesAsync();

        }

        public void DeletePersonTrip(Person person, Trip trip)
        {
            PersonTrip PersonTrip = travelContext.PeopleTrips.Where(x => x.Trip == trip && x. Person == person).FirstOrDefault();

            if(PersonTrip != null)
            {
                travelContext.PeopleTrips.Remove(PersonTrip);
                travelContext.SaveChanges();
            }
        }

        public List<Person>GetPeople(Trip trip)
        {
            List<PersonTrip> PersonTrips = travelContext.PeopleTrips.Where(x => x.Trip == trip).ToList();
            List<Person> People = new List<Person>();
            if (PersonTrips != null)
            {
                foreach (PersonTrip personTrip in PersonTrips)
                {
                    People.Add(travelContext.Users.Where(x => x.Id == personTrip.PersonId).FirstOrDefault());
                }
            }
            return People;
        }

        public List<Trip>GetTrips(Person person)
        {
            List<PersonTrip> PersonTrips = travelContext.PeopleTrips.Where(x => x.Person == person).ToList();
            List<Trip> trips = new List<Trip>();
            if(PersonTrips != null)
            {
                foreach (PersonTrip personTrip in PersonTrips)
                {
                    trips.Add(travelContext.Trips.Where(x => x.Id == personTrip.TripId).FirstOrDefault());
                }
            }
           
            return trips;
        }
    }
}
