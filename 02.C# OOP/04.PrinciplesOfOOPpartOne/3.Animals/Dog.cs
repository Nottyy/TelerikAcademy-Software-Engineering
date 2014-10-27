﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, string sex)
            : base(age, name, sex)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(this.Name + " says bau bau");
        }
    }
}
