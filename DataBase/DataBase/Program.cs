using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using DataBase.Data_Access_Layer;
using DataBase.Models;


namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FactoryDbContext DB = new FactoryDbContext())
            {
                Items item = new Items { Item_Name = "tv", Category_Id = 1,
                    Brand_Id = 1, Weight = 4, Units_In_Inventory = 5, Minimum_Units_In_Inventory = 4,Price=4 };
                DB.Add(item);
                DB.SaveChanges();
            }
        }
    }
}
