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

        public async Task<bool> AddNewOrderItemsAsync(ConcurrentDictionary<int, int> itemsquantity, int orderid)
        {
            try
            {
                foreach (var item in itemsquantity)
                {
                    await Add(new Orderitems { Order_id = orderid, Itme_Id = item.Key, Quantity = item.Value });
                };
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public async Task<List<Orders>> GetTotalsAsync(List<Orders> orders)
        {
            foreach (Orders order in orders)
            {
                order.Total_Cost = await GetTotalCostAsync(order.Order_ID);
                order.Total_Weiget = await GetTotalWeightAsync(order.Order_ID);
            }
            return orders;
        }

        public async Task<Dictionary<int, int>> GetorderandItemswithQuantityAsync(int orderid)
        {
            try
            {

                return await dbSet.Where(oi => oi.Order_id == orderid).ToDictionaryAsync(i => i.Itme_Id, Q => Q.Quantity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<double> GetTotalCostAsync(int orderid)
        {
            try
            {

                return await dbSet.Join(new ItemsRepository(context).GetAllAsync().Result, o => o.Itme_Id, i => i.Item_ID, (quan, cost) => new { total = quan.Quantity * cost.Price }).SumAsync(i => i.total);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<double> GetTotalWeightAsync(int orderid)
        {
            try
            {

                return await dbSet.Join(new ItemsRepository(context).GetAllAsync().Result, o => o.Itme_Id, i => i.Item_ID, (quan, cost) => new { total = quan.Quantity * cost.Weight }).SumAsync(i => i.total);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
