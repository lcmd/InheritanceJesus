using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    class FortuneTeller
    {
        //I'm just setting this up as a regular old class. 
        //Later, I might choose to make it in a game where I inherit from a Human class
        //(and have a customer also inherit from Human), but for our first round, this is great.

        //properties
        public string Name { get; set; } = "Esmerelda";

        public string ExperienceLevel { get; set; } 

        //Methods
               
        public void Greet()
        {
            Console.WriteLine("Hello! Welcome to the one stop shop to knowing your future");            
            Console.WriteLine("Let me see what the Universe will present to you today..");
            Swag();
        }

    //this method asks the user what is their favorite color
    public void AskUser()
    {
        Console.WriteLine("What is your favorite color?");
        Swag();
        string userColor = Console.ReadLine().ToLower();
        Swag();
        switch (userColor)
        {
            case "blue":
                Console.WriteLine("You are a genuine person!");
                break;
            case "red":
                Console.WriteLine("You love all people");
                break;
            case "purple":
                Console.WriteLine("You are royalty");
                break;
            default:
                Console.WriteLine("You think deeply");
                break;
        }
    }

        public void StartService (Service service)
        {
            Console.WriteLine("For you, my OG {0}! Yes, perfect. It only costs {1} and that's fine by ALL the Homies.", service.Name, service.Price);
            Swag();
        }
        public void Farewell()
        {
            Console.WriteLine("Come again homie!");
        }
        //spacer method
        public void Swag()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Create a new fortune teller, giving it a name and experience level.
        /// </summary>
        /// <param name="name">The fortune teller's name.</param>
        /// <param name="experienceLevel">A string value (beginner, intermediate, advanced) for this fortune teller.</param>


        //constructor
        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;
        }
        public FortuneTeller()
        {

        }
    }
}
