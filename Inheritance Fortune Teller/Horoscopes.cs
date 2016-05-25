using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    class Horoscopes:Magic
    {
        public void BirthMonth()
        {
            //created another class that inherits from Magic
            //this class gets alittle more info from the user.
            //created a switch case that asks user to tell me their zodiac sign
            //if they didn't know i have a help section that tells them
            //Console.WriteLine("Just for you I'll add in a special reading based off of your zodiac sign.");



            Console.WriteLine("What is your zodiac sign? If you don't know your zodiac sign enter \"Help\" to show a list of the zodiac signs. ");
            string scope = Console.ReadLine().ToLower();

            if (scope == "help")
            {
                Console.WriteLine("Zodiac Signs: \nCapicorn is Dec 22-Jan 19, \nAquarious is Jan 20-Feb 18, \nPisces is Feb 19-Mar 20, \nAries is Mar 21-Apr 19, \nTaurus is Apr 20-May 20, \nGemini is May 21-June 20, \nCancer is June 21-July 22, \nLeo is July 23-Aug 22, \nVirgo is Aug 23-Sept 22, \nLibra is Sept 23-Oct 22, \nScorpio is Oct 23-Nov 21, \nSagitarius is Nov 22-Dec 21");
                scope = Console.ReadLine().ToLower();
            }
            switch (scope)
            {
                case "capicorn":
                    Console.WriteLine("You are resilient and patient. Great news is on the horizon");
                    break;
                case "aquarius":
                    Console.WriteLine("You are a trendsetter and humanitarian. Keep pushing forward and great things will come to pass");
                    break;
                case "pisces":
                    Console.WriteLine("You are sensitive and mysterious. Be patient and you will find peace.");
                    break;
                case "aries":
                    Console.WriteLine("You are enthusiastic and outgoing. Don't beat yourself up for being different");
                    break;
                case "taurus":
                    Console.WriteLine("You are determined and sensual. Love yourself and be great.");
                    break;
                case "gemini":
                    Console.WriteLine("Yu are intense and explorative. Keep exploring, you will find what you are seeking.");
                    break;
                case "cancer":
                    Console.WriteLine("You are compassionate and contradictiory. Be mindful of the words you speak to others.");
                    break;
                case "leo":
                    Console.WriteLine("You are radiant and a leader. Remember this and keep pushing forward.");
                    break;
                case "virgo":
                    Console.WriteLine("You are caring and confident. Be Great!");
                    break;
                case "libra":
                    Console.WriteLine("You are charming and harmonious. Keep your balance and you will be great!");
                    break;
                case "scorpio":
                    Console.WriteLine("You are resilient and powerful. Use your power and influence for good.");
                    break;
                case "sagitarius":
                    Console.WriteLine("You are optimistic and honest. Travel and explore the world.");
                    break;
                default:
                    Console.WriteLine("Come on now try again..");
                    break;

            }
        }
            public Horoscopes()
        {
            this.PercentEffective = 100;
            this.Price = 65;
            this.Difficulty = DifficultyOptions.medium;
        }

        
            
        }
        
    }

