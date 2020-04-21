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
    public class PersonDataService : IPersonDataService
    {
        private readonly TravelContext travelContext;

        public PersonDataService(TravelContext travelContext)
        {
            this.travelContext = travelContext;
        }

        public async Task<Person> GetPerson(string userName)
        {
            return await travelContext.Users.FirstOrDefaultAsync(x => x.UserName == userName);
        }

        public void UpdatePerson(Person person)
        {
            travelContext.Users.Update(person);
            travelContext.SaveChanges();
        }
    }
}
