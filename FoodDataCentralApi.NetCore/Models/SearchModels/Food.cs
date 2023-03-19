using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
	public class Food
	{
		/// <summary>
		/// FDC ID of the food.
		/// </summary>
		[JsonProperty("fdcId")]
		public int Id { get; set; }

		/// <summary>
		/// Name and description of the food.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Binomial nomenclature of the food.
		/// </summary>
		[JsonProperty("scientificName")]
		public string ScientificName { get; set; }

		/// <summary>
		/// A specific data type of the food.
		/// </summary>
		[JsonProperty("dataType")]
		public string DataType { get; set; }

		/// <summary>
		/// Food's category.
		/// </summary>
		[JsonProperty("foodCategory")]
		public string FoodCategory { get; set; }

	}
}