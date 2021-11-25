using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IAddressEmployeeRepository :IGenericDataRepository<Address_Employees> , INewAddress
    {
        public Task<IEnumerable<Address_Employees>> GetAddresses_ByCity(string city);

    }
}
