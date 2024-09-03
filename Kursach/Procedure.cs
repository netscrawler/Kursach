using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Procedure:Entity_Sush
    {
        string Name { get; set; }
        TimeOnly Length { get; set; }

        public void Add(string name, TimeOnly length)
        {
            this.Name = name;
            this.Length = length;
        }
    }
}
