using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;

namespace FoodDataCentralApi.NetCore.Services
{
	public interface IFoodService
	{
		Task<SearchFoodResult> SearchFoodAsync(QueryForSearchOptions options);
		Task<FoodAndNutrientsResult> GetInformationAboutFood(QueryForFoodInfoOptions options);
	}
}