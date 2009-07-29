using System;

namespace CheeseburgerDecorator
{
    public abstract class Sandwich
    {
        public virtual string Description { get; protected set; }

        public abstract int Calories();
    }
}
