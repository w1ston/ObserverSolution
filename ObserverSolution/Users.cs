using System;

namespace ObserverSolution
{
    public class Users : IObserver
    {
        private IObservable product;

        public Users(IObservable o)
        {
            product = o;
            o.AddObserver(this);
        }

        public void Update(double p)
        {
            if (p < 300)
            {
                Console.WriteLine("Пользователь купил товар по цене: " + p);
                product.RemoveObserver(this);
            }
        }
    }
}