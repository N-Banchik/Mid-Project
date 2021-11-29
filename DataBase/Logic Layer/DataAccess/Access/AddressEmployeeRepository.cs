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
    public class AddressEmployeeRepository : GenericDataRepository<Address_Employees>, IAddressEmployeeRepository
    {
        public AddressEmployeeRepository(DbContext context) : base(context)
        {

        }

        public Address_Employees AddNewAddressAsync( string streetname, int housenumber, int apt, int zipcode, string city)
        {
            try
            {
                Address_Employees newAdd = new Address_Employees { Street_Name = streetname, House_Number = housenumber, Apartment_Number = apt, Zipcode = zipcode, City = city };

                return newAdd;

            }
            catch (Exception)
            {

                throw new Exception("Cannot Add new Address. ");

            };
        }

        public async Task<IEnumerable<Address_Employees>> GetAddresses_ByCity(string city)
        {
            try
            {
                return await dbSet.Where(c => c.City == city).ToListAsync();
            }
            catch (Exception)
            {

                throw new Exception("Problem in Providing the Data");
            }
        }

        public async Task UpdateAddressAsync(Address_Employees address, string streetname, int housenumber, int apt, int zipcode, string city)
        {
            try
            {
                address.Street_Name = streetname;
                address.House_Number = housenumber;
                address.Apartment_Number = apt;
                address.Zipcode = zipcode;
                address.City = city;

                dbSet.Update(address);

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
