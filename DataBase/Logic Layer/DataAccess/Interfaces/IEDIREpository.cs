using DataBase.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
   public interface IEDIREpository:IGenericDataRepository<EDI>
    {
        public Task<List<EDI>> GetEDIsAsync();
        public Task NewEDIAsync(List<Items> items);
        public  Task<List<EDI>> GetbyDateAsync(DateTime fromdate, DateTime TO);
        public Task<List<EDI>> GetnotapprovedAsync();
        public Task<EDI> GetNextEDIAsync();
        public void ApprovedAsync(EDI toapprove,Employees employee);




    }
}
