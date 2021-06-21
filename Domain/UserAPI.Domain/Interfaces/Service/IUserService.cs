using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAPI.Domain.Entities;

namespace UserAPI.Domain.Interfaces.Service
{
    public interface IUserService
    {
        Task<User> Get(Guid id);
        Task<IEnumerable<User>> GetAll();
        Task<User> Insert(User entity);
        Task<User> Update(User entity);
        Task<bool> Delete(Guid id);
    }
}
