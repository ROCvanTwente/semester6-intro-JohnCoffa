using System;
using System.Globalization;
using csharp_advanced.Enums;

namespace csharp_advanced.Extensions
{
	public static class CurrencyExtensions
	{
		public static string ToCurrencyString(this decimal amount, CurrencyEnum currency)
		{
			if (!Enum.IsDefined(typeof(CurrencyEnum), currency))
			{
				return amount.ToString(); 
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
				return amount.ToString(); 
			}

			return string.Format(cultureInfo, "{0:C}", amount);
		}
	}
}
