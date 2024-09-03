using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Procedure_Card : Entity_Sush
    {
        public string[] Zhalobi { get; set; } = null!;
        public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
       

    }
}
