using DataBase.Models;
using DataBase.Models.Connactions;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
   public interface IEDIREpository:IGenericDataRepository<EDI>
    {
        public Task<List<EDI>> GetEDIsAsync();
        public Task NewEDIAsync(List<EDIItems> items);
        public  Task<List<EDI>> GetbyDateAsync(DateTime fromdate, DateTime TO);
        public Task<List<EDI>> GetAllNotapprovedAsync();
        public Task<EDI> GetNextWorkEDIAsync();
        public void ApproveEDIAsync(EDI toapprove,Employees employee);
    }
}
