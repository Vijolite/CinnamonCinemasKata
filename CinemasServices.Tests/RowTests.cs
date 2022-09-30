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


    }
}