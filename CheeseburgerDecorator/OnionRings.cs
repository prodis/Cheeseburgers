using System;

namespace CheeseburgerDecorator
{
    public class OnionRings : SandwichDecorator
    {
        public OnionRings(Sandwich sandwich)
            : base(sandwich)
        {

        }

        public override string Description
        {
            get
            {
                return base.Description + ", Onion Rings";
            }
        }

        public override int Calories()
        {
            return base.Calories() + 140;
        }
    }
}
