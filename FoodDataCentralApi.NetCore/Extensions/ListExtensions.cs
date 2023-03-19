using System.Net;

namespace FoodDataCentralApi.NetCore.Extensions
{
	internal static class ListExtensions
	{
		public static string ConcatenateParametersToStringQuery(this List<KeyValuePair<string, string>> list)
		{
			var parameters = list.Where(param => param.Key != null)
				.Select(param => $"{param.Key}={WebUtility.UrlEncode(param.Value)}");

			return string.Join("&", parameters);
		}
	}
}