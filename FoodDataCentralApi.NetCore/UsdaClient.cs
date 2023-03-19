using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;
using FoodDataCentralApi.NetCore.Services;

namespace FoodDataCentralApi.NetCore
{
    /// <summary>
    /// Provides methods for working with FoodData Central (USDA) services.
    /// </summary>
	public class UsdaClient
	{
        private readonly IFoodService _foodService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">API key for working with the services.</param>
        public UsdaClient(string apiKey)
        {
            _foodService = new FoodService(apiKey);
        }

        /// <summary>
        /// Search for foood by the specified parameters.
        /// </summary>
        /// <param name="options">Search parameters,</param>
        /// <returns>A list of food that matched search parameters.</returns>
        public async Task<SearchAllFoodResult> SearchAllFoodResultAsync(OptionsForSearchAllFood options)
        {
            return await _foodService.SearchFoodAsync(options);
        }

        /// <summary>
        /// Fetches deatils for one food item by FDC ID.
        /// </summary>
        /// <param name="options">Search parameters.</param>
        /// <returns>A single food item by and FDC ID and his nutrients.</returns>
        public async Task<FoodAndNutrientsResult> GetInfoFoodAndNutrientsAsync(OptionsForFoodInfoQuery options)
        {
            return await _foodService.GetInformationAboutFood(options);
        }
    }
}