using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
	public class Food
	{
		[JsonProperty("fdcId")]
		public int Id { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("scientificName")]
		public string ScientificName { get; set; }

		[JsonProperty("dataType")]
		public string DataType { get; set; }

		[JsonProperty("foodCategory")]
		public string FoodCategory { get; set; }

	}
}