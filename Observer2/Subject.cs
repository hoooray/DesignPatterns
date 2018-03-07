using System.Collections.Generic;

namespace Observer2
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            _observers.ForEach(x => x.Update());
        }
    }
}