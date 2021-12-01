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
    public class LogIn_employee : Ilogin
    {
        internal UnitOfWork_Employee employee { get; private set; }

        public LogIn_employee()
        {
            this.employee = new UnitOfWork_Employee();
        }

        public async Task<bool> ChackIfExsistsAsync(string Username)
        {
            try
            {
                return int.TryParse(Username, out int id)
                    ? await employee.employee.GetById(int.Parse(Username)) != null
                    : throw new Exception("ID not a number!");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task ChangePasswordasync(string email, string newpass)
        {
            try
            {
                if (int.TryParse(email, out int id))
                {

                    await employee.employee.UpdatePasswordAsync(id, newpass);

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

        public async Task<bool> LogInAsync(string Username, string password)
        {
            try
            {

                return int.TryParse(Username, out int id)
                    ? await employee.employee.GetOneByCondition(i => i.ID == id && i.Password == Enscryption(password, Username)) != null
                    : throw new Exception("ID not a number!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task RegistarAsync(string streetname, int housenumber, int apt, int zipcode, string city, string first, string last, DateTime Birth, string Pass, string phone, bool manager, string email)
        {
            await employee.employee.AddnewEmployee(first, last, Birth, Pass, phone, manager, employee.addressEmployee.AddNewAddressAsync(streetname, housenumber, apt, zipcode, city));
            await employee.CompleteAsync();
        }

        public string Enscryption(string password, string salt)
        {
            return new ToHash().HashString(password, salt);

        }
    }
}
