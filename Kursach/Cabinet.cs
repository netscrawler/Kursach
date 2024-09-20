using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Cabinet : Entity_Sush
    {
        public string Number { get; set; } = null!;
        public TimeOnly Open {  get; set; }
        public TimeOnly Close { get; set; }
        public string Weekend { get; set; }



        public void Add(string number, TimeOnly Open, TimeOnly Close, string Weekend) { 
            this.Number = number;
            this.Open = Open;
            this.Close = Close;
            this.Weekend = Weekend;
        }
    }
}
