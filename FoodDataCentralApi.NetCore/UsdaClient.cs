using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;
using FoodDataCentralApi.NetCore.Services;

namespace FoodDataCentralApi.NetCore
{
	public class UsdaClient
	{
        private readonly IFoodService _foodService;

        public UsdaClient(string apiKey)
        {
            _foodService = new FoodService(apiKey);
        }

        public async Task<SearchResult> SearchResultAsync(QueryForSearchOptions options)
        {
            return await _foodService.SearchFoodAsync(options);
        }

        public async Task<FoodResult> GetInfoFoodAsync(QueryForFoodInfoOptions options)
        {
            return await _foodService.GetInformationAboutFood(options);
        }
    }
}