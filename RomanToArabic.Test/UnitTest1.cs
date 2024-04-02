using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanToArabic;

namespace RomanToArabic.Tests
{
    [TestClass()]
    public class UnitTestClass1
    {
        [TestMethod()]
        [DataRow("XX", 20)]
        [DataRow("XIx", 19)]
        [DataRow("MMMDCCXXIV", 3724)]
        public void TranslateRomanToArabicTest(string roman, int expected)
        {
            var output = RomanToArabic.TranslateRomanToArabic(roman);
            Assert.AreEqual(output, expected);
        }
    }
}