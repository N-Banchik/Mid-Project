using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface INewAddress
    {
        public Task AddNewAddressAsync(int ID,string streetname,int housenumber,int apt,int zipcode,string city);
    }
}
