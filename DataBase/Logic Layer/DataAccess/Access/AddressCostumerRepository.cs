﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Logic_Layer.DataAccess.Access
{
    public class AddressCostumerRepository : GenericDataRepository<Address_Costumers>, IAddressCostumerRepository
    {
        public AddressCostumerRepository(DbContext context) : base(context)
        {

        }

        public async Task<Address_Costumers> AddNewAddressAsync(int ID, string streetname, int housenumber, int apt, int zipcode, string city)
        {
            try
            {
                Address_Costumers newAdd = new Address_Costumers { Costumer_ID = ID, Street_Name = streetname, House_Number = housenumber, Apartment_Number = apt, Zipcode = zipcode, City = city };
                if (!await dbSet.AnyAsync(i => i.Equals(newAdd)))
                {
                    await base.Add(newAdd);
                    return newAdd;
                }
                else { return null; }


            }
            catch (Exception)
            {

                throw new Exception("Cannot Add new Address. ");

            };
        }

        public async Task<IEnumerable<Address_Costumers>> GetAddresses_ByCity(string city)
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



        public async Task UpdateAddressAsync(Address_Costumers address, string streetname, int housenumber, int apt, int zipcode, string city)
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