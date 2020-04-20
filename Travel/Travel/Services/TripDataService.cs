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
    public class TripDataService : ITripDataService
    {
        private readonly TravelContext travelContext;

        public TripDataService(TravelContext travelContext)
        {
            this.travelContext = travelContext;
        }

        public async Task<List<Trip>> GetAllTripsAsync()
        {
            return await travelContext.Trips.ToListAsync().ConfigureAwait(false);
        }

        
        public async Task<Trip> GetTrip(int Id)
        {
            return await travelContext.Trips.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<Trip> GetTrip(string Name)
        {
            return await travelContext.Trips.FirstOrDefaultAsync(x => x.Name == Name);
        }
        
    }
}
