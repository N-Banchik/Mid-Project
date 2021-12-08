using DataBase.Models;
using DataBase.Models.Connactions;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Access
{
    public class EDIRepository : GenericDataRepository<EDI>, IEDIREpository
    {
        public EDIRepository(DbContext context) : base(context)
        {

        }

        public async Task<List<EDI>> GetEDIsAsync()
        {
            return await dbSet.Include(i => i.employee).Include(i => i.Items).ThenInclude(i => i.Items).ToListAsync();
        }

        public async Task<List<EDI>> GetbyDateAsync(DateTime fromdate, DateTime TO)
        {
            return await dbSet.Include(i => i.employee).Include(i => i.Items).ThenInclude(i => i.Items).Where(i => i.Date.Date >= fromdate.Date && i.Date.Date <= TO.Date).ToListAsync();
        }
        public async override Task<EDI> GetById(int Id)
        {
            return await dbSet.Include(i => i.employee).Include(i => i.Items).ThenInclude(i => i.Items).Where(i => i.EDI_Id == Id).SingleOrDefaultAsync();
        }

        public async Task NewEDIAsync(List<EDIItems> items)
        {
            await dbSet.AddAsync(new EDI { Date = DateTime.Now, Items = items, Total_Weight = items.Sum(i => i.Items.Weight * i.Quantity), Total_Items = items.Sum(i => i.Quantity) });
        }
        public async Task<List<EDI>> GetAllNotapprovedAsync()
        {
            return await dbSet.Include(i => i.Items).Where(i => i.Approved_By == null).ToListAsync();
        }

        public async Task<EDI> GetNextWorkEDIAsync()
        {
            return await dbSet.Include(i => i.Items).ThenInclude(i=>i.Items).Where(i => i.Approved_By == null).OrderBy(i => i.Date).FirstOrDefaultAsync();
        }

        public void ApproveEDIAsync(EDI toapprove, Employees employee)
        {
            EDI update = toapprove;
            update.employee = employee;
            Update(update);
        }

        
    }
}
