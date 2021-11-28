using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_Layer.DataAccess.Interfaces;
using System.Collections.Concurrent;
using Microsoft.EntityFrameworkCore;

namespace Logic_Layer.DataAccess.Access
{
   public class OrderitemsRepository : GenericDataRepository<Orderitems>, IorderItemsRepository
    {
        public OrderitemsRepository(DbContext context) : base(context)
        {
        }

        public Task<bool> AddNewOrderItemsAsync(List<int> itemid, int quantity, int orderid)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<int, int>> GetorderandItemswithQuantityAsync(int orderid)
        {
            try
            {

                return dbSet.Where(oi => oi.Order_id == orderid).ToDictionaryAsync(i => i.Itme_Id,Q=>Q.Quantity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
