using Kursach.Roles;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Person: Entity_Sush
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string Email { get; set; }
        public UInt64 Snils { get; set; }
        public UInt64 Phone { get; set; }



        
        public virtual void Add(string name, string surname, string lastname, string email, DateOnly birthday, string password, UInt64 snils, UInt64 phone, User user)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.LastName = lastname;
            this.Phone = phone;
            this.Email = email;
        }
    }
 }

