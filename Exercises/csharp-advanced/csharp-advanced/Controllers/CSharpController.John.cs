using System.Globalization;
using csharp_advanced.Enums;
using csharp_advanced.Extensions;
using csharp_advanced.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_advanced.Controllers
{
	public partial class CSharpController
	{
		[HttpGet]
		public IActionResult AddMinutes()
		{
			return View();
		}

		public IActionResult AddMinutes(DateTime currentDate, int minutesToAdd)
		{
			DateTime newDate = currentDate.AddMinutes(minutesToAdd);

			var DutchCulture = CultureInfo.CreateSpecificCulture("nl-NL"); 

			string formattedDate = newDate.ToString("dd/MM/yyyy H:mm:ss", DutchCulture);

			ViewBag.NewDate = formattedDate;

			return View();
		}

		[HttpGet]
		public IActionResult ChangeCurrency()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ChangeCurrency(decimal amount, string country)
		{
			// Try to parse the country (currency) string into a valid enum
			if (Enum.TryParse(country, out CurrencyEnum currency) && Enum.IsDefined(typeof(CurrencyEnum), currency))
			{
				string convertedCurrency = amount.ToCurrencyString(currency);
				ViewBag.ConvertedCurrency = convertedCurrency;
			}
			else
			{
				ViewBag.ConvertedCurrency = amount.ToString();
			}

			return View();
		}
	}
}
