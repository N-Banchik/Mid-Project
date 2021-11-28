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
    public class BrandsRepository : GenericDataRepository<Brands>, IBrandsRepository
    {
        public BrandsRepository(DbContext context) : base(context)
        {
        }

        public async Task AddNewBrandAsync(string Brandname, string countryName)
        {
            try
            {
                 await dbSet.AddAsync(new Brands { Brand_Name = Brandname, Manufacturing_Country = countryName });
            }
            catch (Exception)
            {

                throw new Exception("Problem in adding brand");
            }
        }
    }
}
