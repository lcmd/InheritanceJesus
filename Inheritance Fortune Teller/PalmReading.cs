using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    class PalmReading:Magic
    {
        public Random Rnd { get; set; } = new Random();

        //properties
        public List<string> Phrase1 { get; set; } = new List<string>();
        public override string Name { get; set; } = "Palm Reader, Niki";
        public void CreatePhrases()
        {
            Phrase1.Add("What lies behind us and what lies before us are tiny matters compared to what lies within us.");
            Phrase1.Add("Challenge yourself with something you know you could never do, and what you’ll find is that you can overcome anything.");
            Phrase1.Add("Patience is key my child, just wait keep working and all your dreams will come true.");
            Phrase1.Add("Don't be scared..get up and chase your dreams..Really get up NOW!!");
        }
        public override void Work()
        {
            //base.work() calls for parent work to happen before child's work
            base.Work();
            //now let's call a method that will get a result for the palm reader
            Console.WriteLine("Place your hand over your mousepad (Does not matter which hand your choose). Close your eyes and count to 5.");

            Thread.Sleep(6000);
            this.Result = GetPhrase();
        }

        public void CreatePhrases(string phrase)
        {
            Phrase1.Add(phrase);
        }

        public string GetPhrase()
        {
            //local variable
            int randomNumber = Rnd.Next(Phrase1.Count);
            // method element at gets the index of
            return Phrase1.ElementAt(randomNumber);
        }
        //constructor
        //let's override some of the properties of what we inherited from magic and service here.
        public PalmReading()
        {
            this.Price = 60.00M;
            this.PercentEffective = 85;
            this.BlackMagic = false;

            //I want to call my initializer for phrases.
            CreatePhrases();

        }
    }
}

