using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            //Ask the user for a dog name
            Console.WriteLine("What is the dog's name?");
            string userInputDogName = Console.ReadLine();

            //Create a new dog object
            Dog dog = new Dog();
            //Give the dog object a name, color, and age
            dog.Name = userInputDogName;
            dog.Color = "black";
            dog.Age = 1;
            //Execute the getter methods to print these properties and the Eat methods
            Console.WriteLine("The dog's name is " + dog.Name + "." + "\nThe dog's fur is " + dog.Color + "." + "\nThe dog's age is " + dog.Age + ".");
            dog.Eat();

            //Ask the user for cat name
            Console.WriteLine("\nWhat is the cat's name?");
            string userInputCatName = Console.ReadLine();
            //Create a new cat object
            Cat cat = new Cat();
            //Give the cat object a name, color, and age
            cat.Name = userInputCatName;
            cat.Color = "white";
            cat.Age = 2;
            //Execute the getter methods to print these properties and the Eat methods
            Console.WriteLine("The cat's name is " + cat.Name + "." + "\nThe cat's fur is " + cat.Color + "." + "\nThe cat's age is " + cat.Age + ".");
            cat.Eat();

            //Part 2
            //Ask the user for a dog name
            Console.WriteLine("\nWhat is the dog's name?");
            string userInputDogName1 = Console.ReadLine();
            Dog dog1 = new Dog();
            Console.WriteLine("What is the dog's height in feet?");
            int userInputDogHeight1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What color is the dog's fur?");
            string userInputDogColor1 = Console.ReadLine();
            Console.WriteLine("What is the dog's age in years?");
            int userInputDogAge1 = Convert.ToInt16(Console.ReadLine());
            dog1.Name = userInputDogName1;
            dog1.Height = userInputDogHeight1;
            dog1.Color = userInputDogColor1;
            dog1.Age = userInputDogAge1;
            dog1.Eat();
            dog1.Cry();

            //Part 2
            //Ask the user for a dog name
            Console.WriteLine("\nWhat is the cat's name?");
            string userInputCatName1 = Console.ReadLine();
            Cat cat1 = new Cat();
            Console.WriteLine("What is the cat's height in feet?");
            int userInputCatHeight1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What color is the cat's fur?");
            string userInputCatColor1 = Console.ReadLine();
            Console.WriteLine("What is the cat's age in years?");
            int userInputCatAge1 = Convert.ToInt16(Console.ReadLine());
            cat1.Name = userInputCatName1;
            cat1.Height = userInputCatHeight1;
            cat1.Color = userInputCatColor1;
            cat1.Age = userInputCatAge1;
            cat1.Eat();
            cat1.Cry();

            //Creating a list called “animals” and adding some animal objects to the list
            List<Animal> animals = new List<Animal>();
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(dog1);
            animals.Add(cat1);

            //Print the names of all the animals 
            Console.WriteLine("\nPrinting the names of all the animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
            
            //Keep the program from closing until a key is pressed 
            Console.ReadKey();
        }
    }
}
