﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 动物练习
{
    class Dog : Animal
    {
        public Dog()
            : base()
        { }

        public Dog(string name):base(name)
        {
        }

        protected override string getShoutSound()
        {
            return "汪";
        }
        
    }
}
