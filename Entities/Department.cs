using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1.Entities
{
    public class Department
    {
        public Guid Id { get; set; }

        public String Name { get; set; } = null!;


        public String ToShortString()
        {
            return Id.ToString()[0..4]+ "..." + Name;
        }
    }
}

