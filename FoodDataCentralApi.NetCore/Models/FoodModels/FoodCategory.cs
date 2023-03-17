using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class FoodCategory
	{
		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}