using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    abstract class User
    {
        public string Login { get; set; }
        public byte[] Password { get; set; }

        public void Add(String Login, string RawPassword) {
            this.Login = Login;
            this.Password = GetHash(ReadBytes(RawPassword));
            
        }

        public bool Logining(String Login, string RawPassword)
        {
            if (System.Security.Cryptography.SHA256.Equals(this.Password, GetHash(ReadBytes(RawPassword)))&& (this.Login == Login))
            {
                return true;
            }
            return false;
        }

        private byte[] ReadBytes(string RawPassword) { 
            
            return ASCIIEncoding.ASCII.GetBytes(RawPassword);
        }

        private byte[] GetHash(byte[] RawPassword) { 
            return System.Security.Cryptography.SHA256.HashData(RawPassword);
        }
    }
}
