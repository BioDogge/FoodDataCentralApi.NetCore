namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
    public class OptionsForSearchAllFood
    {
		/// <summary>
		/// Food name.
		/// </summary>
		public string Query { get; set; } = string.Empty;

		/// <summary>
		/// Optional. Filter on a specific data type. Default is Foundation.
		/// </summary>
		public string DataType { get; set; } = "Foundation";

		/// <summary>
		/// Optional. Maximum number of results to return for the current page. Default is 10.
		/// </summary>
		public int PageSize { get; set; } = 10;

		/// <summary>
		/// Optional. Page number to retrieve. Default is 1 (first page).
		/// </summary>
		public int PageNumber { get; set; } = 1;

		/// <summary>
		/// Optional. One of the possible values to sort by that field. Default is dataType.keyword.
		/// </summary>
		public string SortBy { get; set; } = "dataType.keyword";

		/// <summary>
		/// Optional. The sort direction for the result. Default is asc.
		/// </summary>
		public string SortOrder { get; set; } = "asc";
	}
}