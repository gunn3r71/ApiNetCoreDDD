using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;
using ApiNetCoreDDD.Domain.Interfaces.Repositories;
using ApiNetCoreDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreDDD.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            try
            {
                return await Context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Email.Equals(email));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public async Task<IEnumerable<User>> FindByNameAsync(string name)
        {
            try
            {
                return await Context.Users.AsNoTracking().Where(u => u.Nome.Contains(name)).ToListAsync();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}