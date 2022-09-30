namespace CinemasCervice
{
    public static class UserInterface
    {
        public static int GenerateRandomNumberOfSeats()
        {
            Random rnd = new Random();
            int x = rnd.Next(3) + 1;
            return x;
        }
    }
}

        