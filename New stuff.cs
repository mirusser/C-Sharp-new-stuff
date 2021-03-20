using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_s_new_in_cSharp_9
{
    #region Init only properties
    public class Person
    {
        //Init only properties
        public string Name { get; init; }

        public readonly string _surname;
        public string Surname
        {
            get => _surname;
            init => _surname = value;
        }
    }

    public class Furniture
    {
        public string Name { get; init; }

        public Furniture(string name)
        {
            Name = name;
        }
    }
    #endregion

    #region Declaring record types
    public record Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public record Dog(string Name, int numberOfLegs);
    #endregion

    public class DoStuff
    {
        public void Run()
        {
            Person person = new()
            {
                Name = "John", //Init only property
                Surname = "Wick" //setting readonly property with init property
            };

            #region Record type 'with' expression
            var dog = new Animal
            {
                Name = "Doggy",
                Age = 3
            };

            var secondDog = dog with { Age = 5 };
            Console.WriteLine($"Second dog name: {secondDog.Name} {Environment.NewLine}Second dog age: {secondDog.Age}");
            #endregion

            #region Comparing record types
            var furniture = new Furniture("Bed");
            var secondFurniture = new Furniture("Bed");

            Console.WriteLine(furniture.Equals(secondFurniture)); //returns false
            Console.WriteLine(furniture == secondFurniture); // returns false

            var doggo = new Dog("Doggo", 5);
            var seccondDogo = new Dog("Doggo", 5);

            Console.WriteLine(doggo.Equals(seccondDogo)); // returns true
            Console.WriteLine(doggo == seccondDogo); // returns true
            #endregion


            Console.WriteLine("Hello World!");
        }
    }
}
