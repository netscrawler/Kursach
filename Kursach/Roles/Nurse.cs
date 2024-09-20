using Kursach.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Nurse : Person
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public override void Add(string name, string surname, string lastname, string email, DateOnly birthday, string password, UInt64 snils, UInt64 phone, User user)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.LastName = lastname;
            this.User = user;
        }
    }
}

