using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
   public interface IAddressEmployeeRepository :IGenericDataRepository<Address_Employees> , INewAddress<Address_Employees>
    {
        public Task<IEnumerable<Address_Employees>> GetAddresses_ByCity(string city);
        public Task UpdateAddressAsync(Address_Employees address, string streetname, int housenumber, int apt, int zipcode, string city);
    }
}
