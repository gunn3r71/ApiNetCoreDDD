using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;
using ApiNetCoreDDD.Domain.Entities.Base;
using ApiNetCoreDDD.Domain.Interfaces.Repositories;
using ApiNetCoreDDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreDDD.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ApplicationDbContext Context;
        private DbSet<T> _entitySet;

        public Repository(ApplicationDbContext context)
        {
            Context = context;
            _entitySet = Context.Set<T>();
        }

        public virtual async Task AddAsync(T entity)
        {
            try
            {
                _entitySet.Add(entity);

                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            try
            {
                var entity = await _entitySet.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id));

                return entity is not null;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _entitySet.AsNoTracking().ToListAsync();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                return await _entitySet.AsNoTracking().SingleOrDefaultAsync(e => e.Id.Equals(id));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public virtual async Task RemoveAsync(T entity)
        {
            _entitySet.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _entitySet.Update(entity);

            await Context.SaveChangesAsync();
        }
    }
}