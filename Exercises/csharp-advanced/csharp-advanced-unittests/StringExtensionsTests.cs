using csharp_advanced.Models;

namespace csharp_advanced_unittests
{
	public class StringExtensionsTests
	{
		[Theory]
		[InlineData("madam", true)]
		[InlineData("hello", false)]
		[InlineData("racecar", true)]
		public void IsPalindrome_InputIsPalindrome_ReturnsBool(string input, bool expected)
		{
			bool result = StringExtensions.IsPalindrome(input);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void IsPalindrome_InputIsNullOrEmpty_ReturnsNullOrEmpty()
		{
			var _IsPalindrome = StringExtensions.IsPalindrome("");
			Assert.False(_IsPalindrome);
		}

	}
}
////Zakriya////