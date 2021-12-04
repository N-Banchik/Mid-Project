using DataBase.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
  public  interface IorderItemsRepository:IGenericDataRepository<Orderitems>
    {
        public Task<Dictionary<int, int>> GetorderandItemswithQuantityAsync(int orderid);
        public Task<bool> AddNewOrderItemsAsync(ConcurrentDictionary<int, int> itemsquantity, int orderid);
        public Task<double> GetTotalCostAsync(int orderid);
        public Task<double> GetTotalWeightAsync(int orderid);
        public Task<List<Orders>> GetTotalsAsync(List<Orders> orders);

    }
}
