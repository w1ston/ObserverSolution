using System;

namespace ObserverSolution
{
    public class Buyers : IObserver
    {
        private IObservable product;

        public Buyers(IObservable o)
        {
            product = o;
            o.AddObserver(this);
        }

        public void Update(double p)
        {
            if (p < 500)
            {
                Console.WriteLine("Покупатель купил товар по цене: " + p);
                product.RemoveObserver(this);
            }
        }
    }
}