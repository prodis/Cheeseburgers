using System;

namespace CheeseburgerDecorator
{
    public class Corn : SandwichDecorator
    {
        public Corn(Sandwich sandwich)
            : base(sandwich)
        {

        }

        public override string Description
        {
            get
            {
                return base.Description + ", Corn";
            }
        }

        public override int Calories()
        {
            return base.Calories() + 70;
        }
    }
}
