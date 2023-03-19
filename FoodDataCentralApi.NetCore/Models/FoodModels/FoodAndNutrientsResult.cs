using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class FoodAndNutrientsResult
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
		/// FDC published.
		/// </summary>
		[JsonProperty("publicationDate")]
		public string PublicationDate { get; set; }

		/// <summary>
		/// A specific data type of the food.
		/// </summary>
		[JsonProperty("dataType")]
		public string DataType { get; set; }

		/// <summary>
		/// NDB food's number.
		/// </summary>
		[JsonProperty("ndbNumber")]
		public int NdbNumber { get; set; }

		[JsonIgnore]
		public FoodCategory FoodCategory { get; set; }

		/// <summary>
		/// Information about the nutrients of food.
		/// </summary>
		[JsonProperty("foodNutrients")]
		public IEnumerable<FoodNutrient> Nutrients { get; set; }
	}
}