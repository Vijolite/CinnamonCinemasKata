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
        [TestCase("A", 1)]
        [TestCase("B", 2)]
        [TestCase("C", 3)]
        public void TestConvertRowLetter(char initial, int result)
        {
            cinema.ConvertRowLetter(initial).Should().Be(result);
        }

    }
}