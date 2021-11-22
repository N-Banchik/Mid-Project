using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DataAccess.Interfaces
{
   public interface IGenericDataRepository<T> where T: class 
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int Id);
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);
        Task<bool> Upsert(T entity);
        Task<IEnumerable<T>> GetByCondition(Expression<Func<T, bool>> predicate);
    }
}
