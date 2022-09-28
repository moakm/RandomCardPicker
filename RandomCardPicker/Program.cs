
namespace RandomCardPicker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many random cards would you like to draw: ");
            Int32.TryParse(Console.ReadLine(), out int nCards);
            string[] cards = new string[nCards];
            cards = CardPicker.PickSomeCards(nCards);
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}