using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public async Task AddnewEmployee(string first, string last, DateTime Birth, string Pass, string phone, bool manager, Address_Employees address,string Email)
        {

            Employees Toadd = new Employees { First_Name = first, last_Name = last, Birthdate = Birth,Hire_Date=DateTime.Now, Password = Pass, Phone_Number = phone, Is_Manager = manager ? 1 : 0, Address = address,Email=Email };


            await base.Add(Toadd);


        }
        public override async Task<ICollection<Employees>> GetByCondition(Expression<Func<Employees, bool>> predicate)
        {
            return await dbSet.Include(i => i.Address).Include(i => i.Shifts).Where(predicate).ToListAsync();
        }

        public override async Task<ICollection<Employees>> GetAllAsync()
        {
            return await dbSet.Include(i => i.Address).Include(i => i.Shifts).ToListAsync();
        }
        public override async Task<Employees> GetOneByCondition(Expression<Func<Employees, bool>> predicate)
        {
            return await dbSet.Include(i => i.Address).Include(i => i.Shifts).Where(predicate).FirstOrDefaultAsync();
        }

        public async Task UpdatePasswordAsync(string email, string newpass)
        {
            try
            {

                Employees user = await GetOneByCondition(i=>i.Email==email);
                if (user.Password != newpass)
                {
                    user.Password = newpass;
                    await Upsert(user);

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
