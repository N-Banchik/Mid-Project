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
    public class OrdersRepository : GenericDataRepository<Orders>, IorderRepository
    {
        public OrdersRepository(DbContext context) : base(context)
        {

        }

        public async Task NewOrderAsync(int costumer, double totalcost, double weight, string cosemail)
        {
            await base.Add(new Orders {Costumer_ID = costumer,Total_Cost =totalcost,Total_Weiget = totalcost,Costumer_Email = cosemail,Ship_Date=DateTime.Now, Order_Date = DateTime.Now,items= new List<Orderitems> { new Orderitems {Itme_Id=2,Quantity=2 } } });
        }

        public async Task UpdateOrderforEMPAsync(int orderid,int emp)
        {
            Orders update = await GetById(orderid);
                update.Ship_Date = DateTime.Now;
                update.Employee_ID = emp;
                await base.Upsert(update);
        }
    }
}
