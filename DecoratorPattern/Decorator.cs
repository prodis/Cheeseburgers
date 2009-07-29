using System;

namespace DecoratorPattern
{
    public abstract class Decorator : Component
    {
        protected Component component;

        public Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            this.component.Operation();
        }
    }
}
