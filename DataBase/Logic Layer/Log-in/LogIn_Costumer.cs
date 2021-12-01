using Logic_Layer.DataAccess.Access;
using Logic_Layer.Encrypt;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.Log_in
{
    public class LogIn_costumer : Ilogin
    {
        internal UnitOfWork_Costumer costumer { get; private set; }

        public LogIn_costumer()
        {
            this.costumer = new UnitOfWork_Costumer();
        }

        public async Task<bool> LogInAsync(string Username, string password)
        {
            try
            {

                return int.TryParse(Username, out int id)
                    ? await costumer.costumer.GetOneByCondition(i => i.Costumer_ID == id && i.Password == password) != null
                    : throw new Exception("ID not a number!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ChackIfExsistsAsync(string Username)
        {
            try
            {
                return int.TryParse(Username, out int id)
                    ? await costumer.costumer.GetById(int.Parse(Username)) != null
                    : throw new Exception("ID not a number!");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task RegistarAsync(string streetname, int housenumber, int apt, int zipcode, string city, string first, string last, DateTime Birth, string Pass, string phone, bool manager, string? email)
        {
            await costumer.costumer.AddnewCostumer(first, last, Birth, email != null ? email : throw new Exception("Email Cannot be empty"), Pass, phone, costumer.addressCostumer.AddNewAddressAsync(streetname, housenumber, apt, zipcode, city));
        }

        public string Enscryption(string password, string salt)
        {
            return new ToHash().HashString(password, salt);
        }

        public async Task ChangePasswordasync(string email, string newpass)
        {
            try
            {
                if (int.TryParse(email, out int id))
                {

                    await costumer.costumer.UpdatePasswordAsync(id, newpass);

                }
                else
                {
                    throw new Exception("ID not a number!");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
