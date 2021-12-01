using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Logic_Layer.Encrypt
{
    class ToHash
    {
        public string HashString(string password,string salt)
        {
            StringBuilder sb = new StringBuilder();
            using HashAlgorithm sha256 = SHA256.Create();
            byte[] hashed = sha256.ComputeHash(Encoding.UTF8.GetBytes(Addsalt(salt)+password));

            foreach (byte bit in hashed)
            {
                sb.Append(bit.ToString("X2"));
            }
            return sb.ToString();
        }

        public string Addsalt(string tosalt)
        {
            return tosalt.Substring(0, 3);
        }
    }
}
