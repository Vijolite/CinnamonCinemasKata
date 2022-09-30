using FluentAssertions;
using NUnit.Framework;
using CinemasService;

namespace CinemasServices.Tests
{
    [TestClass]
    public class CinemaHallTests
    {
        private CinemaHall cinema;

        [SetUp]
        public void Setup()
        {
            cinema = new CinemaHall();
        }
        [TestMethod]
        public void TestCinemaHallCreation()
        {
            var cinema = new CinemaHall();
            cinema.Rows.Length.Should().Be(3);
        }
        [TestMethod]
        public void TestFindFirstEmptySeat()
        {
            var cinema = new CinemaHall();
            var firstEmpty = cinema.FirstEmptySeat();
            $"{firstEmpty.X} {firstEmpty.Y}".Should().Be("0 0");
        }
        [TestCase(0, 0, 0, 1)]
        [TestCase(0, 1, 0, 2)]
        [TestCase(0, 2, 0, 3)]
        [TestCase(0, 4, 1, 0)]
        public void TestFindNextEmptySeat(int initialX, int initialY, int resultX, int resultY)
        {
            var cinema = new CinemaHall();
            var seat = new Seat(initialX, initialY);
            var firstEmpty = cinema.NextEmptySeat(seat);
            $"{firstEmpty.X} {firstEmpty.Y}".Should().Be($"{resultX} {resultY}");
        }
        [TestMethod]
        public void TestAllocateSeatsInEmptyCinema()
        {
            var cinema = new CinemaHall();
            cinema.AllocateSeats(3);
            $"{cinema.Rows[0].Seats[0].IsEmpty} {cinema.Rows[0].Seats[1].IsEmpty} {cinema.Rows[0].Seats[2].IsEmpty}".Should().Be("False False False");
        }
        [TestMethod]
        public void TestNumberOfEmptySeats()
        {
            var cinema = new CinemaHall();
            cinema.AllocateSeats(3);
            cinema.NumberOfEmptySeats().Should().Be(12);
        }
        [TestMethod]
        public void TestNumberOfEmptySeatsInEmptyCinema()
        {
            var cinema = new CinemaHall();
            cinema.NumberOfEmptySeats().Should().Be(15);
        }
    }
}