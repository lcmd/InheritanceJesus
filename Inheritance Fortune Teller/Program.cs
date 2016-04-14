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

            //start of my do while loop that asks the user if he or she wants to play again
            string answer;
            do
            {
                fortuneTeller.Greet(); //say hi
                fortuneTeller.Swag();

                fortuneTeller.StartService((Service)crystalBall); //talk about the service that's being performed
                fortuneTeller.Swag();

                crystalBall.Work(); //run it (do service)
                fortuneTeller.Swag();

                fortuneTeller.AskUser(); //favorite color
                fortuneTeller.Swag();
                // string userColor = Console.ReadLine();
                horoscopes.BirthMonth();
                fortuneTeller.Swag();

                crystalBall.Show(); //display it(state the results of the servcie)
                fortuneTeller.Swag();

                crystalBall.StateEffectiveness(); //state effectiveness of service.
                fortuneTeller.Swag();



                fortuneTeller.Farewell(); //say goodbye.
                fortuneTeller.Swag();
                Console.WriteLine("Do you want to play again? (Y/N)");
                answer = Console.ReadLine();
            } while (answer == "Y");
        }
       
    }
}
