using System;

namespace CheeseburgerComposition
{
    public class Cheeseburger : ICheeseburger
    {
        public Cheeseburger()
        {
            this.Description = "Bread, Hamburger, Cheese";
        }

        public string Description { get; protected set; }

        public int Calories()
        {
            return 300;
        }
    }
}
