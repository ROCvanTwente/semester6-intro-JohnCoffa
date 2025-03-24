using System.Data;

namespace csharp_advanced.Models
{
	public class DateTimeExtensions
	{
		/// <summary>
		/// adds minutes 
		/// </summary>
		/// <param name="CurrentDateTime"></param>
		/// <param name="addMinutes"></param>
		/// <returns></returns>
		public static DateTime AddMinutes(DateTime CurrentDateTime, int addMinutes)
		{
			return CurrentDateTime.AddMinutes(addMinutes);
		}
	}
}
