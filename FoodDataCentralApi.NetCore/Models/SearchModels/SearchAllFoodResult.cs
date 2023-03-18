using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
	public class SearchAllFoodResult
	{
		[JsonProperty("totalHits")]
		public int TotalHits { get; set; }

		[JsonProperty("currentPage")]
		public int CurrentPage { get; set; }

		[JsonProperty("totalPages")]
		public int TotalPages { get; set; }

		public Aggregations Aggregations { get; set; }

		public IEnumerable<Food> Foods { get; set; } = Enumerable.Empty<Food>();
	}
}