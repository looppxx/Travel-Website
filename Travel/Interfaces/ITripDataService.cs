using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Areas.Identity.Data;

namespace Travel.Interfaces
{
    public interface ITripDataService
    {
        Task<List<Trip>> GetAllTripsAsync();

        
        /// <summary>
        /// Get Trip by Id
        /// </summary>
        /// <param name="Id">the id of the trip</param>
        /// <returns></returns>
        Task<Trip> GetTrip(string Id);


    
    }
}
