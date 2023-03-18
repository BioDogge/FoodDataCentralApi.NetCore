using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class FoodNutrient
	{
		[JsonProperty("number")]
		public string NutrientsNumber { get; set; }

		[JsonProperty("name")]
		public string NutrientsName { get; set; }

		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		[JsonProperty("unitName")]
		public string UnitName { get; set; }
	}
}