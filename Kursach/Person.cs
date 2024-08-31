using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; } = null;
        public DateOnly Birthday { get; set; }
        public string Email { get; set; }

        public abstract void Add(string Name, string LastName, string Surname, DateOnly Birthday, string Email);
        

       

    }
}
