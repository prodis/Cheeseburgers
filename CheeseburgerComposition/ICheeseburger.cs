using System;

namespace CheeseburgerComposition
{
    public interface ICheeseburger
    {
        string Description { get; }

        int Calories();
    }
}
