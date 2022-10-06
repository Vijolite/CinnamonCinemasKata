namespace CinemasService.Helpers
{
    public static class Convertions
    {
        public static int ConvertRowLetter(char letter)
        {
            int number = letter;
            int numberForA = 'A';
            return number - numberForA;
        }
        public static int ConvertSeatNumber(int number)
        {
            return number - 1;
        }
        public static char ConvertRowNumberBackToHuman(int number)
        {
            int numberForA = 'A';
            char letter = (char)(number + numberForA);
            return letter;
        }
        public static int ConvertSeatNumberBackToHuman(int number)
        {
            return number + 1;
        }

    }
}
