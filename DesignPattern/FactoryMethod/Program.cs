using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factory;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                factory = new BasicAnimalFactory();
            }
            else
            {
                factory = new RandomAnimalFactory();
            }


            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
        }
    }
}
