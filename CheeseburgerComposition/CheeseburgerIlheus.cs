using System;

namespace CheeseburgerComposition
{
    public class CheeseburgerIlheus : ICheeseburger
    {
        private ICheeseburger cheeseburger;

        public CheeseburgerIlheus(ICheeseburger cheeseburger)
        {
            this.cheeseburger = cheeseburger;
            this.Description = this.cheeseburger.Description + ", Pepper Sauce";
        }

        public string Description { get; protected set; }

        public int Calories()
        {
            return this.cheeseburger.Calories() + 20;
        }
    }
}
