using FoodDataCentralApi.NetCore.Models.FoodModels;

namespace FoodDataCentralApi.NetCore.Tests
{
	public class FoodServiceTests
	{
		private readonly UsdaClient _usdaClient = new("DEMO_KEY");

		[Fact]
		public async Task ShouldFindApplesInFoundationType()
		{
			SearchAllFoodResult searchResult = await _usdaClient.SearchAllFoodResultAsync(new OptionsForSearchAllFood
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
			SearchAllFoodResult searchResult = await _usdaClient.SearchAllFoodResultAsync(new OptionsForSearchAllFood
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
			FoodAndNutrientsResult result = await _usdaClient.GetInfoFoodAndNutrientsAsync(new OptionsForFoodInfoQuery
			{
				FdcId = 1750340
			});

			Assert.Equal(1750340, result.Id);
			Assert.Equal("Apples, fuji, with skin, raw", result.Description);
			Assert.True(result.Nutrients.Count() == 3);
		}

		[Fact]
		public async Task ShouldReturnEmptyFoodList()
		{
			SearchAllFoodResult searchResult = await _usdaClient.SearchAllFoodResultAsync(new OptionsForSearchAllFood
			{
				Query = "fsdafasda13"
			});

			IEnumerable<Food> foods = searchResult.Foods.ToList();

			Assert.Empty(foods);
			Assert.Equal(0, searchResult.TotalHits);
			Assert.Equal(0, searchResult.TotalPages);
		}

		[Fact]
		public async Task CanOverflowTheListOfNutrientsInQuery()
		{
			FoodAndNutrientsResult result = await _usdaClient.GetInfoFoodAndNutrientsAsync(new OptionsForFoodInfoQuery
			{
				FdcId = 1750340,
				Nutrients = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 }
			});

			Assert.Equal(3, result.Nutrients.Count());
		}
	}
}