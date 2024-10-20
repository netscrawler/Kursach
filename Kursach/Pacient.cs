using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Pacient:Person
    {
        

        public ICollection<Procedure_Card> ProcedureCards { get; set; } = new List<Procedure_Card>();
        public override void Add(string name, string surname, string lastname, string email, DateOnly birthday, string password,UInt64 snils, UInt64 phone, User user)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.LastName = lastname;
            this.Snils = snils;
            this.Phone = phone;
        }

        public void New(string name, string surname, string lastname, string email, DateOnly birthday, UInt64 snils, UInt64 phone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.LastName = lastname;
            this.Snils = snils;
            this.Phone = phone;
        }
    }
}
