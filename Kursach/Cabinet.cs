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
        string Number { get; set; } = null!;
        TimeOnly Open {  get; set; }
        TimeOnly Close { get; set; }
        string Weekend { get; set; }



        public void Add(string number, TimeOnly Open, TimeOnly Close, string Weekend) { 
            this.Number = number;
            this.Open = Open;
            this.Close = Close;
            this.Weekend = Weekend;
        }
    }
}
