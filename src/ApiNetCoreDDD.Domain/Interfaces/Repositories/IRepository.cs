using System;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;
using ApiNetCoreDDD.Domain.Entities.Base;

namespace ApiNetCoreDDD.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task RemoveAsync(User user);
        Task<User> GetByIdAsync(Guid id);
    }
}