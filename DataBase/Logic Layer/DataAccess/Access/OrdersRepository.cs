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
    public class OrdersRepository : GenericDataRepository<Orders>, IorderItems
    {
        public OrdersRepository(DbContext context) : base(context)
        {

        }
    }
}
