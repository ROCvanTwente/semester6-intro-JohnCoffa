namespace csharp_advanced.Models
{
	public static class StringExtensions
	{
		/// <summary>
		/// Checks if the input is a palindrome
		/// </summary>
		/// <param name="Palindrome"></param>
		/// <returns></returns>
		public static bool IsPalindrome(this string Palindrome)
		{
			try
			{
				if (string.IsNullOrEmpty(Palindrome)) return false;

				string LowerPalindrome = Palindrome.ToLowerInvariant();
				var Reversed = ReverseString(LowerPalindrome);

				return Reversed == LowerPalindrome;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Niks ingevoerd: {ex.Message}");
				return false;
			}
		}

		/// <summary>
		/// Reverses the string
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private static string ReverseString(string input)
		{
			var Chars = input.ToCharArray();
			Array.Reverse(Chars);
			return new string(Chars);
		}
	}
}
