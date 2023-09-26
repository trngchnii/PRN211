using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_4
{
    internal class Inheritance
    {
        class Employee
        {
            private int id;
            private string name;
            public Employee(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Id
            {
                get { return name; }
                set { name = value; }
            }
        }
        class Manager : Employee
        {
            private string email;
            public Manager(int id, string name, string email):base(id, name)
            {
                this.email = email;
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public override string ToString()
            {
                return $"Id:{Id}, Name:{Name}, Email:{Email}";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<Manager> list = new List<Manager>();
                Manager jack = new Manager(1000, "Jack", "Jack@gmail.com");
                Manager abc = new Manager(1500, "abc", "abc@gmail.com");
                list.Add(jack);
                list.Add(abc);
                foreach (Manager m in list)
                {
                    Console.WriteLine(m);
                }
                Console.ReadLine();
            }
            
        }
    }
}
