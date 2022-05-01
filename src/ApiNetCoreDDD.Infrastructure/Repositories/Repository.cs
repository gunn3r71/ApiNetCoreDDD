using System;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;
using ApiNetCoreDDD.Domain.Entities.Base;
using ApiNetCoreDDD.Domain.Interfaces.Repositories;
using ApiNetCoreDDD.Infrastructure.Context;

namespace ApiNetCoreDDD.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ApplicationDbContext Context;

        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }

        public virtual Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public virtual Task<User> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task RemoveAsync(User user)
        {
            throw new NotImplementedException();
        }

        public virtual Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}