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

		[JsonProperty("foodCategory")]
		public FoodCategory Category { get; set; }

		[JsonProperty("foodNutrients")]
		public IEnumerable<FoodNutrient> FoodNutrients { get; set; }
	}
}