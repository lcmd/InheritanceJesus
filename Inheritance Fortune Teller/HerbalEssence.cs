using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
      class HerbalEssence:Service
    {
        public virtual bool BlackMagic { get; set; }
        //how about another property that gives us the effectiveness of this magical item?
        public virtual int PercentEffective { get; set; }
        //let's make sure all of them have a name!
        public override string Name { get; set; } = "Herbal Essence";
        //let's throw in the level of expertise the fortune teller needs to use this item
        public override string Result { get; set; }

        public override decimal Price { get; set; }

        public override Enum Difficulty { get; set; } = DifficultyOptions.easy;

        //How about a  work -- "make it go now" method?
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my OG {0} chart and show you what we have to offer.", this.Name);
        }
        
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }
        public void StartService(Service service)
        {
            Console.WriteLine("My OG {0} will be perfect for you. It only costs {1} American Dollars and that's fine by ALL the Homies.", service.Name, service.Price);
         
        }
        public void Offer ()
        {
            Console.WriteLine("We offer the following products: ");
            Console.WriteLine("Mint: Will calm your nerves.");
            Console.WriteLine("Purple Swag: Will get you turnt.");
            Console.WriteLine("Lastly, Brownies...they are great!!!");
        }

        public HerbalEssence()
        {
            this.PercentEffective = 100;
            this.Difficulty = DifficultyOptions.medium;
            this.Price = 150;
        }
    }

}
