using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
           // Create a class Animal
            // give this class 4 members that all Animals have in common
            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.canFly = true;
            myBird.wingLength = 2;
            myBird.wingColor = "red";
            myBird.canSwim = true;

            var myReptile = new Reptile()
            {
                AverageLength = 10,
                AverageWeight = 15,
                CanGrowTail = true,
                Habitat = "swamp"
            };
            
            var myAnimals = new Animal[] {myBird, myReptile};

            foreach (var a in myAnimals)
            {
                Console.WriteLine(a.Color);
            }
        }
    }
}
