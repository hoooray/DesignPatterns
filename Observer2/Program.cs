using System;

namespace Observer2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            var s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}
