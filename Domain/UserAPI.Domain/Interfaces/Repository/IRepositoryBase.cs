using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAPI.Domain.Entities;

namespace UserAPI.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : Entity
    {
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(Guid id);
    }
}
