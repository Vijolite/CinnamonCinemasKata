
namespace CinemasService
{
    public static class Convertions
    {
        public static int ConvertRowLetter(char letter)
        {
            int number = letter;
            int numberForA = 'A';
            return number - numberForA + 1;
        }
        public static int ConvertSeatNumber(int number)
        {
            return number - 1;
        }

    }
}
