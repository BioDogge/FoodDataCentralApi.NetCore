namespace FoodDataCentralApi.NetCore.Models.SearchModels
{
    public class QueryForSearchOptions
    {
		public string Query { get; set; } = string.Empty;

		public string DataType { get; set; } = "Foundation";

		public int PageSize { get; set; } = 10;

		public int PageNumber { get; set; } = 1;

		public string SortBy { get; set; } = "dataType.keyword";

		public string SortOrder { get; set; } = "asc";
	}
}