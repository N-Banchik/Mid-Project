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
    public class AddressCostumerRepository : GenericDataRepository<Address_Costumers>, IAddressCostumerRepository
    {
        public AddressCostumerRepository(DbContext context) : base(context)
        {

        }
    }
}
