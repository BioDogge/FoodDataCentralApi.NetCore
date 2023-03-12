using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;

namespace FoodDataCentralApi.NetCore.Services
{
	public interface IFoodService
	{
		Task<SearchResult> SearchFoodAsync(QueryForSearchOptions options);
		Task<FoodResult> GetInformationAboutFood(QueryForFoodInfoOptions options);
	}
}