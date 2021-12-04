using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
  public  interface ICategoryRepository :IGenericDataRepository<Categories>
    {
        public Task AddNewCategoryAsync(string Cname, string disc);
       
    }
}
