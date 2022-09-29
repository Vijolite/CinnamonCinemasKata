using FluentAssertions;
using NUnit.Framework;
using CinemasService;

namespace CinemasServices.Tests
{
    [TestClass]
    public class CinemaHallTests
    {
        [TestMethod]
        public void TestCinemaHallCreation()
        {
            var cinema = new CinemaHall();
            cinema.Rows.Length.Should().Be(3);
        }

    }
}