namespace Sistem_De_Plati.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order comanda = new Order
            {
                Customer = "Neagu Ionut",
                Date = DateTime.Now,
                Total = 100.00m
            };
        }
    }
}