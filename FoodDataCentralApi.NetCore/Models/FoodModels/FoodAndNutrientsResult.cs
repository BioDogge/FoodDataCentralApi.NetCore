using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class FoodAndNutrientsResult
	{
		[JsonProperty("fdcId")]
		public int Id { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("publicationDate")]
		public string PublicationDate { get; set; }

		[JsonProperty("dataType")]
		public string DataType { get; set; }

		[JsonProperty("ndbNumber")]
		public int NdbNumber { get; set; }

		[JsonIgnore]
		public FoodCategory FoodCategory { get; set; }

		[JsonProperty("foodNutrients")]
		public IEnumerable<FoodNutrient> Nutrients { get; set; }
	}
}