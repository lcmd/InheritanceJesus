using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    class Drugs:Service
    {
        //my drug class that is a sibling to Magic
        //want to create additonal classes Mary Jane and Prescription but don't know how at the moment

        public void OtherServices()
        {
            Console.WriteLine("I don't normally do this, but let me tell you about our other services.");
        }
    }
}
