using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Logic_Layer.DataAccess.Access
{
    public class CategoryRepository : GenericDataRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {

        }

       
        public async Task AddNewCategoryAsync(string Cname, string disc)
        {
            try
            {
                Categories add = new Categories { Category_Name = Cname, Description = disc };
                if (dbSet.FirstOrDefaultAsync(i => i.Category_Name == add.Category_Name) == null)
                {
                    await base.Add(add);

                }
                else { throw new Exception("Item already exists"); }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
