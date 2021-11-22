using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.DataAccess.Interfaces;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase.DataAccess.Access
{
    public class ShiftsRepository : GenericDataRepository<Shifts>, IShiftsRepository
    {
        public ShiftsRepository(DbContext context) : base(context)
        {

        }
    }
}
