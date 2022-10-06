using FluentAssertions;
using NUnit.Framework;
using CinemasService;
using CinemasService.Helpers;

namespace CinemasServices.Tests.Helpers.Tests
{
    [TestClass]
    public class ConvertionsTests
    {

        [TestCase("A", 0)]
        [TestCase("B", 1)]
        [TestCase("C", 2)]
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
        [TestCase(0, "A")]
        [TestCase(1, "B")]
        [TestCase(2, "C")]
        public void TestConvertRowLetterBackToHuman(int initial, char result)
        {
            Convertions.ConvertRowLetterBackToHuman(initial).Should().Be(result);
        }

    }
}