using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    public class Cat : Animal, IAnimal
    {
        /*
        public Cat(string name, string color, int age) : base(name, color, age)
        {
        }
        */

        public int Height { get; set; }

        //Eat method implementation 
        public override void Eat()
        {
            Console.WriteLine("The cat eats cat-food.");
        }

        //Cry method implementation
        public string Cry()
        {
            return "Meow!";
        }
    }
}
