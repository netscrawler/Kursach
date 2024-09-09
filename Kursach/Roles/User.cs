using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Roles
{
    public class User
    {
        public string Login { get; set; }
        public byte[] Password { get; set; } = null!;


        public bool Logining(string login, string password)
        {

            if ((this.Login == login) & EqualPass(GetHash(password), this.Password))
            {
                return true;
            }
            return false;
        }


        public void Register(string login, string password)
        {
            if (!string.IsNullOrEmpty(login))
            {
                this.Login = login;
                this.Password = GetHash(password);
            }
        }

        public byte[] GetHash(string password)
        {
            byte[] bPass;
            byte[] passHash;
            bPass = ASCIIEncoding.ASCII.GetBytes(password);
            passHash = System.Security.Cryptography.SHA256.HashData(bPass);
            return passHash;

        }

        private bool EqualPass(byte[] inppass, byte[] pass)
        {
            bool bEqual = false;
            if (inppass.Length == pass.Length)
            {
                int i = 0;
                while ((i < inppass.Length) && (inppass[i] == pass[i]))
                {
                    i += 1;
                }
                if (i == inppass.Length)
                {
                    bEqual = true;
                }
            }
            return bEqual;
        }
    }
}
