using FoodDataCentralApi.NetCore.Models.FoodModels;

namespace FoodDataCentralApi.NetCore.Tests
{
	public class FoodServiceTests
	{
		[Fact]
		public async Task ShouldFindApplesInFoundationType()
		{
			UsdaClient usdaClient = new UsdaClient("DEMO_KEY");

			SearchAllFoodResult searchResult = await usdaClient.SearchAllFoodResultAsync(new OptionsForSearchAllFood
			{
				Query = "apple"
			});

			IEnumerable<Food> foods = searchResult.Foods.ToList(); 

			Assert.True(foods.Any());
			Assert.True(foods.Count() <= searchResult.Aggregations.DataType.Foundation);
			Assert.Equal(searchResult.Aggregations.DataType.Foundation, foods.Count());
		}

		[Fact]
		public async Task ShouldFindApplesInBrandedType()
		{
			UsdaClient usdaClient = new UsdaClient("DEMO_KEY");

			SearchAllFoodResult searchResult = await usdaClient.SearchAllFoodResultAsync(new OptionsForSearchAllFood
			{
				Query = "apple",
				DataType = "Branded"
			});

			IEnumerable<Food> foods = searchResult.Foods.ToList();

			Assert.True(foods.Any());
			Assert.True(foods.Count() <= searchResult.Aggregations.DataType.Branded);
			Assert.Equal(10, foods.Count());
		}

		[Fact]
		public async Task ShouldFindApplesInfoWithNutrients()
		{
			UsdaClient usdaClient = new UsdaClient("DEMO_KEY");

			FoodAndNutrientsResult result = await usdaClient.GetInfoFoodAndNutrientsAsync(new OptionsForFoodInfoQuery
			{
				FdcId = 1750340,
				Nutrients = new List<int> { 203, 204, 205 }
			});

			Assert.Equal(1750340, result.Id);
			Assert.Equal("Apples, fuji, with skin, raw", result.Description);
			Assert.True(result.Nutrients.Count() == 3);
		}
	}
}