using System;

namespace CheeseburgerInheritance
{
    public class CheeseburgerItarare : Cheeseburger
    {
        public CheeseburgerItarare()
            : base()
        {
            this.Description += ", Corn";
        }

        public override int Calories()
        {
            return base.Calories() + 70;
        }
    }
}
