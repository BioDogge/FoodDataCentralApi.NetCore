using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
	public class Aggregations
	{
		/// <summary>
		/// Count of foods in different types.
		/// </summary>
		public DataType DataType { get; set; }

		[JsonIgnore]
		public string Nutrients { get; set; }
	}

	public class DataType
	{
		/// <summary>
		/// Count of foods in Branded types.
		/// </summary>
		[JsonProperty("Branded")]
		public long Branded { get; set; }

		/// <summary>
		/// Count of foods in Survey types.
		/// </summary>
		[JsonProperty("Survey (FNDDS)")]
		public int Survey { get; set; }

		/// <summary>
		/// Count of foods in Foundation types.
		/// </summary>
		[JsonProperty("Foundation")]
		public int Foundation { get; set; }
	}
}