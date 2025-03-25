using System;
using System.Globalization;
using csharp_advanced.Enums;

namespace csharp_advanced.Extensions
{
	public static class CurrencyExtensions
	{
		public static string ToCurrencyString(this decimal amount, CurrencyEnum currency)
		{
			// Check if the currency is valid; if not, return just the amount
			if (!Enum.IsDefined(typeof(CurrencyEnum), currency))
			{
				return amount.ToString(); // Return amount as string if currency is unknown
			}

			CultureInfo cultureInfo = currency switch
			{
				CurrencyEnum.EUR => new CultureInfo("nl-NL"),
				CurrencyEnum.USD => new CultureInfo("en-US"),
				CurrencyEnum.GBP => new CultureInfo("en-GB"),
				CurrencyEnum.JPY => new CultureInfo("ja-JP"),
				CurrencyEnum.CAD => new CultureInfo("en-CA"),
			};

			if (cultureInfo == null)
			{
				return amount.ToString(); // If culture is null, just return the amount as a string
			}

			return string.Format(cultureInfo, "{0:C}", amount);
		}
	}
}
