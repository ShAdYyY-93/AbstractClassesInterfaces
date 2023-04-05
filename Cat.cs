using Homework___1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___1.Entities
{
    internal class Cat : Animal, ICat
    {

        public Cat(string name, int MyAge, bool Homely, bool Wildly, string Home)
        {
            Name = name;
            Age = MyAge;
            this.Inside = Homely;
            this.Outside = Wildly;
            City = Home;

        }

        public override void PrintAnimal()
        {
            Console.WriteLine(this.Name + "printed me");

        }

        public void Eat(string food)
        {
            Console.WriteLine("I want something fishy " + food);
        }
    }
    
     
    
}
