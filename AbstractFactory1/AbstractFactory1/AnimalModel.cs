using System;

namespace AbstractFactory1
{
    public abstract class Herbivore
    {
    }

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }

    public class Wildebeest : Herbivore
    {
    }

    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class Bison : Herbivore
    {
    }
 
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}