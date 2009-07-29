using System;

namespace CheeseburgerComposition
{
    public class CheeseburgerItarare : ICheeseburger
    {
        private ICheeseburger cheeseburger;

        public CheeseburgerItarare(ICheeseburger cheeseburger)
        {
            this.cheeseburger = cheeseburger;
            this.Description = this.cheeseburger.Description + ", Corn";
        }

        public string Description { get; protected set; }

        public int Calories()
        {
            return this.cheeseburger.Calories() + 70;
        }
    }
}
