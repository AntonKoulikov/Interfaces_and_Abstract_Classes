using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    public interface IAnimal
    {
        //Getter methods
        //Setter methods
        string Name { get; set; }
        string Color { get; set; }
        int Height { get; set; }
        int Age { get; set; }

        //Eat method
        void Eat();

        //Cry method
        string Cry();

    }
}
