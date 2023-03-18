using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;

namespace FoodDataCentralApi.NetCore.Services
{
	public interface IFoodService
	{
		Task<SearchAllFoodResult> SearchFoodAsync(OptionsForSearchAllFood options);
		Task<FoodAndNutrientsResult> GetInformationAboutFood(OptionsForFoodInfoQuery options);
	}
}