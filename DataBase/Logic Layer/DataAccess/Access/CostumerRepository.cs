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
    public class CostumerRepository : GenericDataRepository<Costumers>, ICostumerRepository
    {
        public CostumerRepository(DbContext context) : base(context)
        {

        }

        public async Task AddnewCostumer(string first,string last,DateTime Birth,string email,string Pass,string phone) 
        {
           
            Costumers Toadd = new Costumers {First_Name = first,last_Name = last,Birthdate = Birth,Email = email,Password = Pass,Phone_Number = phone};
           await base.Add(Toadd);
        }
    }
}
