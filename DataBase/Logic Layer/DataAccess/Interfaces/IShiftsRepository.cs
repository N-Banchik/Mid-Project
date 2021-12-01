using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
 public   interface IShiftsRepository : IGenericDataRepository<Shifts>
    {
        public Task<bool> UpdateLastShiftAsync(int id);
        public Task NewShiftAsync(int id);


    }
}
