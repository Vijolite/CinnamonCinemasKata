using FluentAssertions;
using NUnit.Framework;
using CinemasService;

namespace CinemasServices.Tests
{
    [TestClass]
    public class RowTests
    {
        private Row row;

        [SetUp]
        public void Setup()
        {
            row = new Row();
        }
        [TestMethod]
        public void TestRowCreation()
        {
            var row = new Row();
            row.Seats.Length.Should().Be(5);
        }
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        public void TestConvertSeatNumber(int initial, int result)
        {
            row.ConvertSeatNumber(initial).Should().Be(result);
        }

    }
}