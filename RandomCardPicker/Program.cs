
namespace RandomCardPicker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cards = new string[];
            cards = CardPicker.PickSomeCards(2);
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}