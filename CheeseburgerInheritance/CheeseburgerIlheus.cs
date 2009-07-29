using System;

namespace CheeseburgerInheritance
{
    public class CheeseburgerIlheus : Cheeseburger
    {
        public CheeseburgerIlheus()
            : base()
        {
            this.Description += ", Pepper Sauce";
        }

        public override int Calories()
        {
            return base.Calories() + 20;
        }
    }
}
