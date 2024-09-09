using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Procedures_History:Entity_Sush
    {
        DateTime Date { get; set; }
        public ICollection<Procedure> Procedures { get; set; }=new List<Procedure>()
        public Procedure_Card Card { get; set; }

        public void Add(Procedure procedure, DateTime date)
        {
            this.Date = date;
        }
    }
}
