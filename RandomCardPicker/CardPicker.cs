
namespace RandomCardPicker
{
    public class CardPicker
    {
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] deck = new string[52];
            string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            string[] drawnCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                drawnCards[i] = RandomValue() + RandomSuit();
            }

            return drawnCards;
        }

        private static string RandomSuit()
        {
            throw new NotImplementedException();
        }

        private static string RandomValue()
        {
            
        }
    }
}
