using System.Data;

namespace csharp_advanced.Models
{
	public static class DateTimeExtensions
	{
		/// <summary>
		/// adds minutes 
		/// </summary>
		/// <param name="CurrentDateTime"></param>
		/// <param name="addMinutes"></param>
		/// <returns></returns>
		public static DateTime AddMinutes(this int addMinutes, DateTime CurrentDateTime)
		{
			return CurrentDateTime.AddMinutes(addMinutes);

		}
	}
}
