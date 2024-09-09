using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public abstract class Entity_Sush
    {
        public Guid Id { get; set; }

        public virtual void Add()
        {
            this.Id = Guid.NewGuid();

        }
    }

    
}
