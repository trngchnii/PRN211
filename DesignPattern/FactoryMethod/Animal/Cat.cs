﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Animal
{
    class Cat : IAnimal
    {
        public string getName()
        {
            return "I am Cat";
        }
    }
}
