using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IPassword
    {
        public Task UpdatePasswordAsync(string email, string newpass);
    }
}
