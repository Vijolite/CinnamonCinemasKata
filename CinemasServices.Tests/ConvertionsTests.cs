using FluentAssertions;
using NUnit.Framework;
using CinemasService;

namespace CinemasServices.Tests
{
    [TestClass]
    public class ConvertionsTests
    {

        [TestCase("A", 1)]
        [TestCase("B", 2)]
        [TestCase("C", 3)]
        public void TestConvertRowLetter(char initial, int result)
        {
            Convertions.ConvertRowLetter(initial).Should().Be(result);
        }
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        public void TestConvertSeatNumber(int initial, int result)
        {
            Convertions.ConvertSeatNumber(initial).Should().Be(result);
        }

    }
}