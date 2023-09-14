using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    // Best performance method to clone an object
    // Another way: Library (Automapper, ...), JSON Serialization
    public interface ICloneable
    {
        object Clone();
    }

    public class Person : ICloneable
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Address Address { get; set; } = default!;

        /// <summary>
        /// Create an "shallow" copy of object by creating a new object (only copy nonstatic field of the current object)
        /// If a field is a reference type, the reference is copied but the referred object is not (copy address)
        /// Therefore, the original object (field) and its clone refer to the same object.
        /// </summary>
        /// <returns></returns>
        public Person ShallowClone()
        {
            return (Person) this.MemberwiseClone();
        }

        /// <summary>
        /// Deep clone current object
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Person()
            {
                Name = Name,
                Age = Age,
                Address = (Address) Address.Clone()
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Street: {Address.Street}, City: {Address.City}, State: {Address.State}";
        }
    }

    public class Address : ICloneable
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public object Clone()
        {
            return new Address()
            {
                Street = Street,
                City = City,
                State = State
            };
        }
    }
}
