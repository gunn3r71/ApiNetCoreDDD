using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;
using ApiNetCoreDDD.Domain.Interfaces.Repositories;
using ApiNetCoreDDD.Infrastructure.Context;

namespace ApiNetCoreDDD.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<User> FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}