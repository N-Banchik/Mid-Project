using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using DataBase.Context;
using DataBase.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Storage;
using System.Formats;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Program
    {
        static async Task Main(string[] args)
        {
            FactoryDbContext context = new FactoryDbContext();

            List<Items> items = await context.Items.Include(i => i.Brand).Include(i => i.Category).ToListAsync();
            await context.EDIs.AddAsync(new EDI { Date=DateTime.Now,Items=new List<Items> { items[1],items[1],items[0], items[1], items[1], items[0],items[2] },Total_Items=7,Total_Weight=45});
            await context.SaveChangesAsync();

        }
        public static Task<string> Enscryption(string password, string salt)
        {
            return Task.Factory.StartNew(() => HashString(password, salt));
        }
        public static string HashString(string password, string salt)
        {
            StringBuilder sb = new StringBuilder();
            using HashAlgorithm sha256 = SHA256.Create();
            byte[] hashed = sha256.ComputeHash(Encoding.UTF8.GetBytes(Addsalt(salt) + password));

            foreach (byte bit in hashed)
            {
                sb.Append(bit.ToString("X2"));
            }
            return sb.ToString();
        }

        public static string Addsalt(string tosalt)
        {
            return tosalt.Substring(0, 3);
        }
    }
}
