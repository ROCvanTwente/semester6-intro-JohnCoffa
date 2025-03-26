using csharp_advanced.Models;

namespace csharp_advanced_unittests
{
    public class DateTimeExtensionsTests
    {
        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void AddMinutes_InputIsMinutes_ReturnsDateTime(int input)
        {
            // 24 maart 2025 om 14:30
            DateTime testDateTime = new DateTime(2025, 3, 24, 14, 30, 0);

            var result = DateTimeExtensions.AddMinutes(input, testDateTime);

            var expected = testDateTime.AddMinutes(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-3)]
        [InlineData(-2)]
        [InlineData(-360)]
        public void AddMinutes_InputIsNegativeMinutes_ReturnsDateTime(int input)
        {
            // 24 maart 2025 om 14:30
            DateTime testDateTime = new DateTime(2025, 3, 24, 14, 30, 0);

            var result = DateTimeExtensions.AddMinutes(input, testDateTime);

            var expected = testDateTime.AddMinutes(input);
            Assert.Equal(expected, result);
        }

    }
}