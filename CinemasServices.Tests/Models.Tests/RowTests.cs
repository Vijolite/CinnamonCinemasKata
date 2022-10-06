using FluentAssertions;
using NUnit.Framework;
using CinemasService.Models;

namespace CinemasServices.Tests.Models.Tests
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