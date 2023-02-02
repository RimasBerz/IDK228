using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1.Entities
{
    public class Managers
    {
        public Guid Id { get; set; }
        public string Surname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Secname { get; set; } = null!;

        public Guid IdMainDep { get; set; }
        public Guid IdSecDep { get; set; }

        public Guid IdChief { get; set; }

        public String ToShortString()
        {
            return $"{Id.ToString()[..4]}...{Surname} {Name[0]}. {Secname[0]}.";
        }
    }
}
