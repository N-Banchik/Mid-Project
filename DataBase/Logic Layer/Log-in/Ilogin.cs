using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.Log_in
{
    interface Ilogin<T>
    {
        public Task<T> LogInAsync(string Username, string password);
        public Task<bool> ChackIfExsistsAsync(string Username);
        public Task RegistarAsync(string streetname, int housenumber, int apt, int zipcode, string city, string first, string last, DateTime Birth, string Pass, string phone, bool manager, string email);
        public string Enscryption(string password,string salt);
        public Task ChangePasswordasync(string email,string newpass);
        

    }
}
