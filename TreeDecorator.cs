using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteTree XTree = new ConcreteTree();
            ConcreteDecoratorToy Toys = new ConcreteDecoratorToy();
            ConcreteDecoratorLights Lights = new ConcreteDecoratorLights();

            // Link decorators
            Toys.SetComponent(XTree);
            Lights.SetComponent(Toys);

            Lights.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Tree
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ConcreteTree : Tree
    {
        public override void Operation()
        {
            Console.WriteLine("the tree is standing");
        }
    }
    // "Decorator"
    abstract class Decorator : Tree
    {
        protected Tree component;

        public void SetComponent(Tree component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class ConcreteDecoratorToy : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "Toys";
            Console.WriteLine("Toys installed");
        }
    }

    // "ConcreteDecoratorB" 
    class ConcreteDecoratorLights : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Lights installed");
            TreeLightsOn();
        }
        void TreeLightsOn()
        {
            Console.WriteLine("Christmas tree glows");
        }
    }
}
