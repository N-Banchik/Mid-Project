using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Logic_Layer.DataAccess.Access
{
   public class GenericDataRepository<T> :DbContext, IGenericDataRepository<T> where T : class
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

        public virtual async Task Delete(int id)
        {

            dbSet.Remove(await dbSet.FindAsync(id));
            
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<ICollection<T>> GetByCondition(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<T> GetById(int Id)
        {
            return await dbSet.FindAsync(Id);
        }

        public virtual async Task<T> GetOneByCondition(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).FirstOrDefaultAsync();
        }

        public virtual async Task<bool> Upsert(T entity)
        {
            dbSet.Update(entity);
            return false;
        }
    }
}
