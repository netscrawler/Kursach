using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Procedure:Entity_Sush
    {
        public string Name { get; set; }
        public TimeOnly Length { get; set; }

        public DateTime Time { get; set; }

        public void Add(string name, TimeOnly length)
        {
            this.Name = name;
            this.Length = length;
        }

        public void AddDate(DateTime time) { 
            this.Time = time;
        }
    }
}
