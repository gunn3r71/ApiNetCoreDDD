using System.Collections.Generic;
using System.Threading.Tasks;
using ApiNetCoreDDD.Domain.Entities;

namespace ApiNetCoreDDD.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> FindByEmailAsync(string email);
        Task<IEnumerable<User>> FindByNameAsync(string name);
    }
}