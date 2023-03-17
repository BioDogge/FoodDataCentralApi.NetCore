using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class Nutrient
	{
		[JsonProperty("number")]
		public string Number { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("unitName")]
		public string UnitName { get; set; }
	}
}