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
    public class EmployeeRepository : GenericDataRepository<Employees>, IEmployeeRepository, IPassword
    {
        public EmployeeRepository(DbContext context) : base(context)
        {

        }
        public async Task AddnewEmployee(string first, string last, DateTime Birth, string Pass, string phone, bool manager)
        {

            Employees Toadd = new Employees { First_Name = first, last_Name = last, Birthdate = Birth, Password = Pass, Phone_Number = phone, Is_Manager = manager ? 1 : 0 };
            if (dbSet.FirstOrDefaultAsync(i => i == Toadd) == null)
            {

                await base.Add(Toadd);
            }
            else { throw new Exception("Costumer already exists"); }

        }

        public async Task UpdatePasswordAsync(int id, string newpass)
        {
            try
            {

                Employees user = await GetById(id);
                if (user.Password != newpass)
                {
                    user.Password = newpass;
                }
                else
                {
                    throw new Exception("Password cannot be the same");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
