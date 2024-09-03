using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Disease:Entity_Sush
    {
        public string Name { get; set; }
        public ICollection<Procedure_Card> Procedures { get; set; } = new List<Procedure_Card>();
    }

}
