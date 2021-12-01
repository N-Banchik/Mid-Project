using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
 public   interface IorderRepository : IGenericDataRepository<Orders>
    {
        public Task NewOrderAsync(int costumer,double totalcost,double weight,string cosemail);
        public Task UpdateOrderforEMPAsync(int orderid, int emp);
    }
}
