using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Areas.Identity.Data;

namespace Travel.Interfaces
{
    public interface IPersonTripDataService
    {
        /// <summary>
        /// Add Trip to the given person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="trip"></param>
        /// <returns></returns>
        public Task AddPersonTrip(Person person, Trip trip);

        public void DeletePersonTrip(Person person,Trip trip);

        
        /// <summary>
        /// Get Trips by person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public List<Trip>GetTrips(Person person);

        /// <summary>
        /// Get People by trips
        /// </summary>
        /// <param name="trip"></param>
        /// <returns></returns>
        public List<Person>GetPeople(Trip trip);


       
    }
}
