using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal
{
    class Duck : IAnimal
    {
        public string getName()
        {
            return "I am Duck";
        }
    }
}
