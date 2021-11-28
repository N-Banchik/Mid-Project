using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IItemsRepository :IGenericDataRepository<Items>
    {
        public Task AddNewItemAsync(string name,int category,int brand,double Wight,int Unitsinv,int unitsmin,double price);
        public Task UpdateInventoryAsync(int itemid, int unitstoadd);
        public Task<IEnumerable<Items>>GetItemsToOrderAsync();
        public Task<IEnumerable<Items>>GetItemsInstockAsync();
    }
}
