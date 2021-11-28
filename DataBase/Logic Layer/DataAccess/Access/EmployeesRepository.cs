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
    public class EmployeeRepository : GenericDataRepository<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {

        }
        public async Task AddnewEmployee(string first, string last, DateTime Birth, string email, string Pass, string phone,bool manager)
        {

            Employees Toadd = new Employees { First_Name = first, last_Name = last, Birthdate = Birth, Password = Pass, Phone_Number = phone,Is_Manager= manager?1:0 };
            await base.Add(Toadd);
        }
    }
}
