using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string? RoleName
        {
            get
            {
                return Role switch
                {
                    "Admin" => Admin?.Name,
                    "Doctor" => Doctor?.Name,
                    "Nurse" => Nurse?.Name,
                    _ => null
                };
            }
        }
        public Admin? Admin { get; set; }
        public Doctor? Doctor { get; set; }
        public Nurse? Nurse { get; set; }
    }
}
