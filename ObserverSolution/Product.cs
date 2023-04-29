using System.Collections.Generic;
using System.Linq;

namespace ObserverSolution
{
    public class Product : IObservable
    {
        private List<IObserver> _observer;
        private double _price;

        public Product(double p)
        {
            _price = p;
            _observer = new List<IObserver>();
        }

        public void ChangePrice(double p)
        {
            _price = p;
            Notify();
        }

        public void AddObserver(IObserver o)
        {
            _observer.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observer.Remove(o);
        }

        public void Notify()
        {
            foreach (IObserver o in _observer.ToList())
            {
                o.Update(_price);
            }
        }
    }
}