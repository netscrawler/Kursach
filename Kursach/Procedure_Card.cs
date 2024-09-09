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
        public ICollection<Procedures_History> Procedures_History { get; set; }= new List<Procedures_History>();
        public Pacient Pacient { get; set; }
        public Doctor Doctor { get; set; }

        public void Add(string[] Zhalobi)
        {
            this.Zhalobi = Zhalobi;
        }
       

    }
}
