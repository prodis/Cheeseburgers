using System;

namespace CheeseburgerDecorator
{
    public class PepperSauce : SandwichDecorator
    {
        public PepperSauce(Sandwich sandwich)
            : base(sandwich)
        {

        }

        public override string Description
        {
            get
            {
                return base.Description + ", Pepper Sauce";
            }
        }

        public override int Calories()
        {
            return base.Calories() + 20;
        }
    }
}
