using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserAPI.Domain.Entities;
using UserAPI.Domain.Interfaces.Repository;
using UserAPI.Infra.Data.Context;

namespace UserAPI.Infra.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataSet;

        public RepositoryBase(MyContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(u => u.Id.Equals(id));

                if (result == null)
                    return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();
                
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Get(Guid id)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(u => u.Id.Equals(id));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                var result = await _dataSet.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> Insert(T entity)
        {
            try
            {
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();

                entity.DataCadastro = DateTime.Now;
                _dataSet.Add(entity);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public async Task<T> Update(T entity)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(u => u.Id.Equals(entity.Id));

                if (result == null)
                    return null;

                entity.DataCadastro = result.DataCadastro;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return entity;
        }
    }
}
