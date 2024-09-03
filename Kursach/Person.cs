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


        public void Add(string name,string surname,string lastname,DateOnly birthday,string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.LastName = lastname;
            this.Birthday = birthday;
            this.Email = email;

        }
        public Person Create(string name, string surname, string lastname, DateOnly birthday, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.LastName = lastname;
            this.Birthday = birthday;
            this.Email = email;
            return this;

        }








    }
}
