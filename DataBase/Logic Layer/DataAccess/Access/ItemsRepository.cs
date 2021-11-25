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
    public class ItemsRepository : GenericDataRepository<Items>, IItemsRepository
    {
        public ItemsRepository(DbContext context) : base(context)
        {

        }
    }
}
