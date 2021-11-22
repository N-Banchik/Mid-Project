using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DataBase.DataAccess.Interfaces;

namespace DataBase.DataAccess.Access
{
   public class GenericDataRepository<T> : IGenericDataRepository<T> where T : class
    {
        protected DbContext context;
        internal DbSet<T> dbSet;
       
        public GenericDataRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            

        }
        public virtual async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> Delete(int id)
        {
            return  false;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<T> GetById(int Id)
        {
            return await dbSet.FindAsync(Id);
        }

        public virtual async Task<bool> Upsert(T entity)
        {
            return false;
        }
    }
}
