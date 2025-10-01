using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsfLibrary_G7.Models
{
    public class Staff : Person
    {
        public string Position { get; }
        public string Department { get; }

        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }
    }
}
