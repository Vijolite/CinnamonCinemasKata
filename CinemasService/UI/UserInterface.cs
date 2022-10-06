namespace CinemasService.UI
{
    public static class UserInterface
    {
        public static int GenerateRandomNumberOfSeats()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 4);
            return x;
        }
    }
}

