using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    public interface IAddressCostumerRepository : IGenericDataRepository<Address_Costumers>, INewAddressCostumer<Address_Costumers>
    {
        public Task<IEnumerable<Address_Costumers>> GetAddresses_ByCity(string city);
        public Task UpdateAddressAsync(Address_Costumers address);
        public Task<List<Address_Costumers>> GetwithuserAsync();

    }
}
