using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    class CrystalBall:Magic 
    {
        //straight up field. I really don't need a property. Just using globally so random behaves well.
        private Random random = new Random();

        //properties
        protected List<string> Phrases { get; set; } = new List<string>();

        public override string Name { get; set; } = "Crystal Ball";


        public override void Work()
        {
            base.Work();
            //now let's call a method that will get a result for the crystal ball
            this.Result = GetPhrase();

        }

        protected void CreatePhrases()
        {
            Phrases.Add("Night time is a dark place for you.");           
            Phrases.Add("I see shiny objects in your near future");
            Phrases.Add("The decorating around you needs some help.");
            Phrases.Add("MC is the dopest artist coming out of Cleveland, OH");
            Phrases.Add("Lexus is awesome, you don't know her but you should!");
        }

        //let's create an overloaded method now
        protected void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }

        private string GetPhrase()
        {
            //local variable
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);

        }

        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public CrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 85; //was 65
            this.BlackMagic = true;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases.
            CreatePhrases();
        }


    }
}
