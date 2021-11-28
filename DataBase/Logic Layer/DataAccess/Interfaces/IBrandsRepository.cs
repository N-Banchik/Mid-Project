using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IBrandsRepository :IGenericDataRepository<Brands>
    {
        public Task AddNewBrandAsync(string Brandname, string countryName);
    }
}
