using csharp_advanced.Models;

namespace csharp_advanced_unittests
{
	public class StringExtensionsTests
	{
		[Fact]
		public void IsPalindrome_InputIsPalindrome_ReturnsTrue()
		{
			var _IsPalindrome = StringExtensions.IsPalindrome("Abba");
			Assert.True(_IsPalindrome);
		}

		[Fact]
		public void IsPalindrome_InputIsPalindrome_ReturnsFalse()
		{
			var _IsPalindrome = StringExtensions.IsPalindrome("BaBa");
			Assert.False(_IsPalindrome);
		}
		[Fact]
		public void IsPalindrome_InputIsPalindrome_ReturnsNull()
		{
			var _IsPalindrome = StringExtensions.IsPalindrome("");
			Assert.False(_IsPalindrome);
		}

	}
}