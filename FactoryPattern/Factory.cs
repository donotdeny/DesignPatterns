using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // private lại không cho bên ngoài gọi linh tinh mà phải gọi qua factory 
        private Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        // Inner factory để giải quyết vấn đề private constructor
        public class PersonFactory
        {
            // Id auto increase from 0
            public static int IdPersonFactory { get; set; } = 0;
            public Person CreatePerson(string name)
            {
                return new Person(IdPersonFactory++, name);
            }
        }
    }
}
