using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IEmployeeRepository :IGenericDataRepository<Employees>
    {
        public Task AddnewEmployee(string first, string last, DateTime Birth, string Pass, string phone, bool manager, Address_Employees address);
        public Task UpdatePasswordAsync(int id, string newpass);
    }
}
