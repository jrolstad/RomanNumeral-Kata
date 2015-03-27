using NUnit.Framework;
using roman_numeral;

namespace roman_numeral_tests
{
    [TestFixture]
    public class RomanNumeralConverterTests
    {
        [Test]
        [TestCase("I",1)]
        [TestCase("V",5)]
        [TestCase("X",10)]
        [TestCase("L",50)]
        [TestCase("C",100)]
        [TestCase("D",500)]
        [TestCase("M",1000)]
        public void Convert_RomanNumeral_ConvertsToArabicNumber(string roman, int expectedArabic)
        {
            // Arrange
            var converter = new RomanNumeralConverter();

            // Act
            var result = converter.Convert(roman);

            // Assert
            Assert.That(result,Is.EqualTo(expectedArabic),"Unexpected value when converting from '{0}'",roman);
        }
    }
}