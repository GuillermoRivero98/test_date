using NUnit.Framework;
using Ucu.Poo.TestDateFormat;

namespace Library.Tests
{
    [TestFixture]
    public class DateFormatterTests
    {
        [Test]
        public void TestChangeFormat_ValidDate()
        {
            // Arrange
            string inputDate = "10/11/1997";
            string expectedDate = "1997-11-10";

            // Act
            string result = DateFormatter.ChangeFormat(inputDate);

            // Assert
            Assert.That(result, Is.EqualTo(expectedDate));
        }

        [Test]
        public void TestChangeFormat_InvalidDate()
        {
            // Arrange
            string inputDate = "11-10-1997";

            // Act & Assert
            Assert.That(() => DateFormatter.ChangeFormat(inputDate), Throws.TypeOf<FormatException>());
        }

        [Test]
        public void TestChangeFormat_BlankDate()
        {
            // Arrange
            string inputDate = "";

            // Act
            string result = DateFormatter.ChangeFormat(inputDate);

            // Assert
            Assert.That(result, Is.EqualTo(""));
        }
    }
}


