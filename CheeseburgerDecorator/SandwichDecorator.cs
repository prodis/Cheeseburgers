using System;

namespace CheeseburgerDecorator
{
    public abstract class SandwichDecorator : Sandwich
    {
        protected Sandwich sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            this.sandwich = sandwich;
        }

        public override string Description 
        {
            get
            {
                return this.sandwich.Description;
            }
        }

        public override int Calories()
        {
            return this.sandwich.Calories();
        }
    }
}
