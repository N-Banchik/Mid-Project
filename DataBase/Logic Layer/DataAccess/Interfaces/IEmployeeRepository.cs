using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    public interface IEmployeeRepository : IGenericDataRepository<Employees>
    {
        public Task AddnewEmployee(string first, string last, DateTime Birth, string Pass, string phone, bool manager, Address_Employees address, string email);
        public Task UpdatePasswordAsync(string Email, string newpass);
    }
}
