using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    using System;
    using System.Collections.Generic;

    // Prototype Interface
    public interface ICloneable
    {
        ICloneable Clone();
    }

    // Concrete Prototype
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ICloneable Clone()
        {
            // Shallow copy
            return (ICloneable)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Client Code
    class Program
    {
        static void Main(string[] args)
        {
            Person originalPerson = new Person { Name = "Alice", Age = 30 };
            Person clonedPerson = (Person)originalPerson.Clone();
            

            originalPerson.Display();
            clonedPerson.Display();
            Console.ReadLine();
        }
    }

}
