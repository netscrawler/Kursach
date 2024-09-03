using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class Procedures_History:Entity_Sush
    {
        Procedure procedure {  get; set; }
        DateTime date { get; set; }

        public void Add(Procedure procedure, DateTime date)
        {
            this.procedure = procedure;
            this.date = date;
        }
    }
}
