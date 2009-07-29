using System;

namespace CheeseburgerDecorator
{
    public class Cheeseburger : Sandwich
    {
        public Cheeseburger()
        {
            this.Description = "Bread, Hamburger, Cheese";
        }

        public override int Calories()
        {
            return 300;
        }
    }
}
