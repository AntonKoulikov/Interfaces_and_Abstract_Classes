using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    public class Dog : Animal, IAnimal
    {
        //Constructor
        /*
        public Dog(string name, string color, int age) : base(name, color, age)
        {
        }
        */

        public int Height { get; set; }

        //Eat method implementation
        public override void Eat()
        {
            Console.WriteLine("The dog eats dog-food.");
        }

        //Cry method implementation
        public string Cry()
        {
            return "Woof!";
        }

    }
}
