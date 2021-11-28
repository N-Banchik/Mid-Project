using DataBase.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IorderItemsRepository:IGenericDataRepository<Orderitems>
    {
        public Task<Dictionary<int, int>> GetorderandItemswithQuantityAsync(int orderid);
        public Task<bool> AddNewOrderItemsAsync(List<int> itemid, int quantity, int orderid);

    }
}
