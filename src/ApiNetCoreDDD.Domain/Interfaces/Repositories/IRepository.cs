using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;
using ApiNetCoreDDD.Domain.Entities.Base;

namespace ApiNetCoreDDD.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T user);
        Task UpdateAsync(T user);
        Task RemoveAsync(T user);
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> ExistsAsync(Guid id);
    }
}