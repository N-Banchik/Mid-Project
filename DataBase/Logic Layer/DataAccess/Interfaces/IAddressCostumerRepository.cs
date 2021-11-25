using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IAddressCostumerRepository:IGenericDataRepository<Address_Costumers>,INewAddress
    {
        public Task<IEnumerable<Address_Costumers>> GetAddresses_ByCity(string city);
    }
}
