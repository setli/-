using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public Cat()
        {
        }

        public override string Shout()
        {
            return "喵";
        }
    }
}
