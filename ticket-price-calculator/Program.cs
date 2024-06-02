// See https://aka.ms/new-console-template for more information

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 65 || age <= 12)
            {
                Console.WriteLine("Ticket price: GHC7");
            }
            else
            {
                Console.WriteLine("Ticket price: GHC10");
            }
        }
    }
}
