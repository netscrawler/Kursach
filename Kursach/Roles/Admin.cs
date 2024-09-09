using Kursach.Roles;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public  class Admin:Person
    {
        public User User { get; set; } = null!;
       

        public override void Add(string name, string surname, string lastname, string email, DateOnly birthday, string password, UInt64 snils, UInt64 phone, User u)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.LastName = lastname;
            this.Phone = phone;
            this.Snils = snils;
            this.User= u;
        }
    }
    }
