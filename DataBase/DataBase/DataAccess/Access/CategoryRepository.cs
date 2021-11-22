using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.DataAccess.Access;
using DataBase.DataAccess.Interfaces;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase.DataAccess.Access
{
    public class CategoryRepository : GenericDataRepository<Categories>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) :base(context)
        {

        }
    }
}
