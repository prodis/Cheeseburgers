using System;

namespace DecoratorPattern
{
    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public ConcreteDecoratorA(Component component)
            : base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
            this.addedState = "some state";
        }
    }
}
