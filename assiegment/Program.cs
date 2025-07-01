namespace assiegment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PerSmall = 25;
            int PerLarge = 35;
            double percent = 6.00;

            Console.WriteLine("welcome to Islam's Carpet Cleaning Service");
            Console.WriteLine(" per small=25$");
            Console.WriteLine(" per large=35$");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine(" Estimates are valid for 30 days :");
            Console.WriteLine("number of small: ");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number of large: ");
            int large = Convert.ToInt32(Console.ReadLine());

            int cost = (small * PerSmall) + (large * PerLarge);
            double tax = cost * percent;
            double total = cost + tax;
            Console.WriteLine($"the total price is{total}$");

        }
    }
}
