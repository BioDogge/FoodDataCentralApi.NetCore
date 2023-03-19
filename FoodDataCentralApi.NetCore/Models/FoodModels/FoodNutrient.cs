using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class FoodNutrient
	{
		/// <summary>
		/// Nutrient's number.
		/// </summary>
		[JsonProperty("number")]
		public string NutrientsNumber { get; set; }

		/// <summary>
		/// Nutrient's name.
		/// </summary>
		[JsonProperty("name")]
		public string NutrientsName { get; set; }

		/// <summary>
		/// Amount of nutrients in the specified food.
		/// </summary>
		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		/// <summary>
		/// Unit of nutrient.
		/// </summary>
		[JsonProperty("unitName")]
		public string UnitName { get; set; }
	}
}