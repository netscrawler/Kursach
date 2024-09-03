using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public  class Admin : Entity_Sush
    {
        
            User User { get; set; } = null!;
            Person Person { get; set; } = null!;


            public void Add(Person person, string password)
            {
                this.Person = person;
                this.User = new User().Register(person.Email, password);

            }
        }
    }
