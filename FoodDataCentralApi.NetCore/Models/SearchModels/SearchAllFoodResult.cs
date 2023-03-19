using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
	public class SearchAllFoodResult
	{
		/// <summary>
		/// Count of foods that matched search options.
		/// </summary>
		[JsonProperty("totalHits")]
		public int TotalHits { get; set; }

		/// <summary>
		/// Number of current page in the foods list.
		/// </summary>
		[JsonProperty("currentPage")]
		public int CurrentPage { get; set; }

		/// <summary>
		/// Count of foods list total pages.
		/// </summary>
		[JsonProperty("totalPages")]
		public int TotalPages { get; set; }

		/// <summary>
		/// Information about the count of foods of different types.
		/// </summary>
		public Aggregations Aggregations { get; set; }

		/// <summary>
		/// Information about the foods returned.
		/// </summary>
		public IEnumerable<Food> Foods { get; set; } = Enumerable.Empty<Food>();
	}
}