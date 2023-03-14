using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{   
    public abstract class Animal //Abstract super class
    {
        //Attributes
        public string name;
        public string color;
        public int age; 

        //Constructors
        /*
        public Animal(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        */

        //Getter methods
        //Setter methods 
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        //Abstract void eat method
        public abstract void Eat();
    }
}
