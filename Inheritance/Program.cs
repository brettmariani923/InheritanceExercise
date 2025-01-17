using System;
using System.Security.Cryptography.X509Certificates;

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
          
            Bird bird= new Bird();
            { 
            bird.Name = "Penguin";
            bird.Age = 3;
            bird.Carnivore = true;
            bird.Nocturnal = false;
            bird.Lifespan = 12;
            bird.Color = "black and white";
            bird.BirdOfPrey = false;
            bird.MateForLife = true;
            }

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

             Reptile reptile= new Reptile();
             {
                reptile.Name = "Kimodo Dragon";
                reptile.Lifespan = 25;
                reptile.Carnivore= true;
                reptile.Nocturnal = false;
                reptile.Color = "green";
                reptile.ClawSize = "big";
                reptile.EatsBugs = true;
                reptile.Poisonous = true;

             }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine($"The {reptile.Name} is one of the craziest lizards on planet earth. Living {reptile.Lifespan} years in captivity, the stories of Kimodo Dragons beng a Carnvorous killng \n machine is absolutely {reptile.Carnivore}");
            Console.WriteLine($"Thankfully for the animals on God's green earth, it is {reptile.Nocturnal} that the retptile is awake at night. ");
            Console.WriteLine($"The Kimodo Dragon is a big {reptile.Color} beast with {reptile.ClawSize} meaty claws.");
            Console.WriteLine($"It is {reptile.EatsBugs} that Kimodo Dragons eat bugs, but they prefer human flesh. It is {reptile.Poisonous} that the kimodo dragon is a big \ngreen poisonous beast with {reptile.ClawSize} meaty claws");

            Console.WriteLine($"Get in the bucket NOW!!! Big Boy!! The zoo keeper cried out at the {bird.Name} from across the room");
            Console.WriteLine($"It was weighing time, and the {bird.Age} month old penguin, tapioca, was casuing a fuss.");
            Console.WriteLine($"With mighty strides, tapioca, the {bird.Color} beast waddled across the room into the arms of its servant caregiver");
            Console.WriteLine($"Is tapioca a killer? No, luckliy for the people of planet earth that is {bird.BirdOfPrey}. But do penguins mate for life? \nYES, thats {bird.MateForLife}");

            Console.WriteLine($"But is he a carnivore? Yes, its {bird.Carnivore}. Hes pescatarian");

            Console.WriteLine($"Is he noctournal? Only when he feels like it! But no, for the most part, that is {bird.Nocturnal}");
            
            Console.WriteLine("FIN");
        }
    }
}
