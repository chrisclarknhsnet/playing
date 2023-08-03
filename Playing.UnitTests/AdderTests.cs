using Playing.Library;

namespace Playing.UnitTests
{
    public class AdderTests
    {
        private readonly Adder _adder;

        public AdderTests()
        {
            _adder = new Adder();
        }

        [Fact]
        public void Adds_Two_Numbers()
        {
            // Arrange
            var no1 = 4;
            var no2 = 8;

            // Act
            var result = _adder.AddNumbers(no1, no2);

            // Assert
            Assert.Equal(9, result);
        }
    }
}