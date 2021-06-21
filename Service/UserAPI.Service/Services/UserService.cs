using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAPI.Domain.Entities;
using UserAPI.Domain.Interfaces.Repository;
using UserAPI.Domain.Interfaces.Service;

namespace UserAPI.Service.Services
{
    public class UserService : IUserService
    {
        private IRepositoryBase<User> _repo;

        public UserService(IRepositoryBase<User> repo)
        {
            _repo = repo;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repo.Delete(id);
        }

        public async Task<User> Get(Guid id)
        {
            return await _repo.Get(id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<User> Insert(User entity)
        {
            return await _repo.Insert(entity);
        }

        public async Task<User> Update(User entity)
        {
            return await _repo.Update(entity);
        }
    }
}
