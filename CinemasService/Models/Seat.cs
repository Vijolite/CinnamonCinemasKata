namespace CinemasService.Models
{
    public class Seat
    {
        public bool IsEmpty { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Seat()
        {
            IsEmpty = true;
        }
        public Seat(int x, int y)
        {
            IsEmpty = true;
            X = x;
            Y = y;
        }
        public void Allocate()
        {
            IsEmpty = false;
        }
    }
}
