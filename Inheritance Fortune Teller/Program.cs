using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            //our game will start here
            //let's create a fortune teller

            FortuneTeller fortuneTeller = new FortuneTeller();
            CrystalBall crystalBall = new CrystalBall();
            Horoscopes horoscopes = new Horoscopes();
            PalmReading palmReading = new PalmReading();
            HerbalEssence herbalEssence = new HerbalEssence();

            Console.WriteLine("1. Crystal Ball");
            Console.WriteLine("2. Horoscopes");
            Console.WriteLine("3. Palm Reading");
            Console.WriteLine("4. Herbal Essence");
            int fortuneMenu = int.Parse(Console.ReadLine());
                   
            string answer;
            do
            {
                switch (fortuneMenu)
                {
                    case 1:
                        fortuneTeller.Greet(); //say hi
                        fortuneTeller.Swag();
                        fortuneTeller.StartService((Service)crystalBall); //talk about the service that's being performed
                        fortuneTeller.Swag();
                        crystalBall.Work(); //run it (do service)
                        fortuneTeller.Swag();
                        crystalBall.Show(); //display it(state the results of the servcie)
                        fortuneTeller.Swag();
                        crystalBall.StateEffectiveness(); //state effectiveness of service.
                        fortuneTeller.Swag();
                        fortuneTeller.AskUser(); //favorite color
                        fortuneTeller.Swag();
                        fortuneTeller.Farewell(); //say goodbye.
                        fortuneTeller.Swag();
                        break;

                    case 2:
                        fortuneTeller.Greet();
                        fortuneTeller.StartService((Service)horoscopes);
                        fortuneTeller.Swag();
                        horoscopes.StateEffectiveness();
                        horoscopes.BirthMonth();
                        fortuneTeller.Swag();
                        fortuneTeller.Farewell();
                        break;

                    case 3:
                        fortuneTeller.Greet(); //say hi
                        fortuneTeller.Swag();
                        fortuneTeller.StartService((Service)palmReading); //talk about the service that's being performed
                        fortuneTeller.Swag();
                        palmReading.Work(); //run it (do service)
                        fortuneTeller.Swag();
                        palmReading.Show(); //display it(state the results of the servcie)
                        fortuneTeller.Swag();
                        palmReading.StateEffectiveness(); //state effectiveness of service.
                        fortuneTeller.Swag();
                        fortuneTeller.Farewell(); //say goodbye.
                        fortuneTeller.Swag();
                        break;

                    case 4:
                        Console.WriteLine("Please Enter the Password!");
                        Console.WriteLine("HINT: ROYgBIV..think of colors!!!");
                        string password = Console.ReadLine().ToLower();

                        string realPassword = "green";
                        if (password == realPassword)
                        {
                            fortuneTeller.Greet();
                            herbalEssence.StateEffectiveness();
                            herbalEssence.StartService((Service)herbalEssence);
                            herbalEssence.Work();
                            herbalEssence.Offer();
                            Console.WriteLine("Choose a product:");                          
                            List<string> productType = new List<string>() { "1. Mint", "2. Purple Swag", "3. Brownies" };
                            foreach (string product in productType)
                            {
                                Console.WriteLine(product);
                            }
                            int choice = int.Parse(Console.ReadLine());
                            Console.WriteLine("Great Choice..ENJOY!!");
                            fortuneTeller.Farewell();
                        }
                        break;

                    default:
                        Console.WriteLine("That was not an option.");
                        break;
            }

                //start of my do while loop that asks the user if he or she wants to play again
                Console.WriteLine("Do you want to play again? (Y/N)");
                answer = Console.ReadLine().ToLower(); 
            } while (answer == "y");
        }
       
    }
}
