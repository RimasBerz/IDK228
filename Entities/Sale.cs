using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADO1.Entities
{
    public class Sale
    {
        public Guid Id { get; set; }

        public int Cnt { get; set; }

        public DateTime Moment {get;set;}

        public String ToShortString()
        {
            return $"{Id.ToString()[..4]}...{Cnt} {Moment}";
        }
    }
}
