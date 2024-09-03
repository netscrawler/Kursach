using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Nurse : Entity_Sush
    {
        User User { get; set; } = null!;
        Person Person { get; set; } = null!;


        public void Add(string name, string surname, string lastname, DateOnly birthday, string email, string password)
        {
            this.Person = new Person().Create(name, surname, lastname, birthday, email);
            this.User = new User().Register(this.Person.Email, password);

        }
    }
}

