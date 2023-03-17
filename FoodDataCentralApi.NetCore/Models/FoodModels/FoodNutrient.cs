using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class FoodNutrient
	{
		[JsonProperty("nutrient")]
		public Nutrient Nutrient { get; set; }

		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		[JsonProperty("min")]
		public decimal Min { get; set; }

		[JsonProperty("max")]
		public decimal Max { get; set; }
	}
}