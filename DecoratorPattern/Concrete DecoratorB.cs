using System;

namespace DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component)
            : base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
            this.AddedBehavior();
        }

        private void AddedBehavior()
        {

        }
    }
}
