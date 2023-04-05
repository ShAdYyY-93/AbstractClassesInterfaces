using Homework___1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___1.Entities
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Inside { get; set; }
        public bool Outside { get; set; }
        public string City { get; set; }
        public virtual void DoSomething()
        {
            Console.WriteLine("test");
        }

        public abstract void PrintAnimal();

    }
}
