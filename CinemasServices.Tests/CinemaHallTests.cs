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
        public void TestFindNextEmptySeat(int initialX, int initialY, int resultX, int resultY)
        {
            var cinema = new CinemaHall();
            var seat = new Seat(initialX, initialY);
            var firstEmpty = cinema.NextEmptySeat(seat);
            $"{firstEmpty.X} {firstEmpty.Y}".Should().Be($"{resultX} {resultY}");
        }


    }
}