using FluentAssertions;
using NUnit.Framework;
using CinemasService;

namespace CinemasServices.Tests
{
    [TestClass]
    public class SeatTests
    {
        [TestMethod]
        public void TestSeatCreation()
        {
            var seat = new Seat();
            seat.IsEmpty.Should().Be(true);
        }
        [TestMethod]
        public void TestSeatAllocation()
        {
            var seat = new Seat();
            seat.Allocate();
            seat.IsEmpty.Should().Be(false);
        }
    }
}