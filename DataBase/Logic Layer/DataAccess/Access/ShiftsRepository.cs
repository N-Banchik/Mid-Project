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
    public class ShiftsRepository : GenericDataRepository<Shifts>, IShiftsRepository
    {
        public ShiftsRepository(DbContext context) : base(context)
        {

        }

        public async Task NewShiftAsync(int id)
        {
            try
            {
                await dbSet.AddAsync(new Shifts { Employee_ID = id, Shift_Start = DateTime.Now });
            }
            catch (Exception )
            {

                throw new Exception("Cannot Add new shift ");
            }
        }

        public async Task<bool> UpdateLastShiftAsync(int id)
        {
            try
            {
                Shifts temp = await dbSet.Where(e => e.Employee_ID == id).OrderBy(i=>i.Shift_Start).LastOrDefaultAsync();
                if (temp == null)
                {
                    return false;
                }
                else
                {
                    
                    temp.Shift_End = DateTime.Now;
                    temp.Total_Time = temp.Shift_End.Value.Subtract(temp.Shift_Start).Duration().TotalMinutes / 60;


                    return true;
                }

            }
            catch (AggregateException )
            {

                return false;
            }
        }

        
    }
}
