namespace ObserverSolution
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product(600);
            Buyers buyers = new Buyers(product);
            Users users = new Users(product);
            
            product.ChangePrice(300);
            product.ChangePrice(100);
            
        }
    }
}