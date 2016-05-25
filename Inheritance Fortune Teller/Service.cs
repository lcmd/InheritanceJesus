﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Fortune_Teller
{
    internal enum DifficultyOptions { easy, medium, hard};

   abstract class Service
    {
        //Properties
        //Services have costs
        //I want this to be overrideable.
        public abstract decimal Price { get; set; } 

        //all services have a name.
        public abstract string Name { get; set; }    

        //Let's make a property to store some result. Let's just say it's a single result and it's a string.
        public abstract string Result { get; set; }

        //added 4.19
        public virtual Enum Difficulty { get; set; } = DifficultyOptions.medium;

        //we might want to track other things too, but we can add on later if we'd like
    }
}
