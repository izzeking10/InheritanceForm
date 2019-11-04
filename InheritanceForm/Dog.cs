﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceForm
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            Species = Species.DOG;
            CanFly = false;
        }
    }
}
