using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
	public class Aggregations
	{
		public DataType DataType { get; set; }

		[JsonIgnore]
		public string Nutrients { get; set; }
	}

	public class DataType
	{
		[JsonProperty("Branded")]
		public long Branded { get; set; }

		[JsonProperty("Survey (FNDDS)")]
		public int Survey { get; set; }

		[JsonProperty("Foundation")]
		public int Foundation { get; set; }
	}
}