using DataBase.Models;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Access
{
    public class EDIRepository : GenericDataRepository<EDI>,IEDIREpository
    {
        public EDIRepository(DbContext context) : base(context)
        {
            
        }

        public async Task<List<EDI>> GetEDIsAsync()
        {
            return await dbSet.Include(i => i.employee).Include(i => i.Items).ToListAsync();
        }
        
        public async Task<List<EDI>> GetbyDateAsync(DateTime fromdate,DateTime TO)
        {
            return await dbSet.Include(i => i.employee).Include(i => i.Items).Where(i => i.Date >= fromdate && i.Date >= TO).ToListAsync();
        }
        public async override Task<EDI> GetById(int Id)
        {
            return await dbSet.Include(i => i.employee).Include(i => i.Items).Where(i => i.EDI_Id == Id).SingleOrDefaultAsync();
        }

        public async Task NewEDIAsync(List<Items> items)
        {
            await dbSet.AddAsync(new EDI { Date = DateTime.Now, Total_Items = items.Count, Total_Weight = items.Sum(i => i.Weight), Items = items });
        }
         public async Task<List<EDI>> GetnotapprovedAsync()
        {
            return await dbSet.Include(i => i.Items).Where(i => i.Approved_By == null).ToListAsync();
        }

        public async Task<EDI> GetNextEDIAsync()
        {
            return await dbSet.Include(i => i.Items).Where(i => i.Approved_By == null).OrderByDescending(i => i.Date).FirstOrDefaultAsync();
        }

        public  void ApprovedAsync(EDI toapprove, Employees employee)
        {
            EDI update = toapprove;
            update.employee = employee;
             Update(update);
        }
    }
}
