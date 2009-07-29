using System;
using System.Collections.Generic;

namespace CheeseburgerInheritance
{
    public class Cheeseburger
    {
        public Cheeseburger()
        {
            this.Description = "Bread, Hamburger, Cheese";
        }

        public string Description { get; protected set; }

        public virtual int Calories()
        {
            return 300;
        }
    }
}
