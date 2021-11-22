using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.DataAccess.Interfaces;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase.DataAccess.Access
{
    public class OrdersRepository : GenericDataRepository<Orders>, IordersRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        {

        }
    }
}
