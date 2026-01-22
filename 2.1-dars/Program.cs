namespace _2._1_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Banana";
            product.Price = 18000;
            product.DateRelease = DateTime.Now;
            product.BestBefore = DateTime.Now;
        }
    }
}
