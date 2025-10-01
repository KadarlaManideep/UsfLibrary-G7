using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsfLibrary_G7.Models
{
    public class Person
    {
        public string Name { get; }
        public string Email { get; }
        public string ID { get; }

        protected Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }

        public override string ToString() => $"Name: {Name}, ID: {ID}";
    }
}
