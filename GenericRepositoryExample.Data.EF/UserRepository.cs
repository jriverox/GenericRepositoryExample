using GenericRepositoryExample.Domain.Entities;
using GenericRepositoryExample.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Data.EF
{
    public class UserRepository: RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext context):base(context)
        {
            
        }

        public async Task<IEnumerable<User>> GetBirthdayUsers()
        {
            var startDate = DateTime.Today.Date;
            var endDate = startDate.AddDays(1);
            return await Context.Users.Where(x => x.BirthDate >= startDate && x.BirthDate < endDate).ToListAsync();
        }
    }
}
