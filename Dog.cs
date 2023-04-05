using Homework___1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework___1.Entities
{
    internal class Dog : Animal, IDog
    {
        public void Bark()
        {
            Console.WriteLine("AV AV AV");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine("The dog printed me");

        }
        public override void DoSomething()
        {
            base.DoSomething(); 
        }

    }
}
