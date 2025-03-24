namespace csharp_advanced.Models
{
	public static class StringExtensions
	{
		public static bool IsPalindrome(this string Palindrome)
		{
			try
			{

				if (string.IsNullOrEmpty(Palindrome))
				{
					return false;
				}

				string LowerPalindrome = Palindrome.ToLowerInvariant();
				var Chars = LowerPalindrome.ToCharArray();
				Array.Reverse(Chars);
				var Reversed = new string(Chars);
				return Reversed == LowerPalindrome;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Fout bij het controleren van palindroom: {ex.Message}");
				return false;
			}
		}
	}
}
