using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FoodDataCentralApi.NetCore.Services
{
	internal static class ResultFromJson
	{
		private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			ContractResolver = new CamelCasePropertyNamesContractResolver(),
			DateParseHandling = DateParseHandling.None
		};

		public static T ConvertFromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json, settings);
	}
}