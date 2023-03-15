namespace FoodDataCentralApi.NetCore.Tests
{
	public class FoodServiceTests
	{
		[Fact]
		public async Task ShouldFindApplesInFoundationType()
		{
			UsdaClient usdaClient = new UsdaClient("DEMO_KEY");

			SearchFoodResult searchResult = await usdaClient.SearchResultAsync(new QueryForSearchOptions
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

			SearchFoodResult searchResult = await usdaClient.SearchResultAsync(new QueryForSearchOptions
			{
				Query = "apple",
				DataType = "Branded"
			});

			IEnumerable<Food> foods = searchResult.Foods.ToList();

			Assert.True(foods.Any());
			Assert.True(foods.Count() <= searchResult.Aggregations.DataType.Branded);
			Assert.Equal(10, foods.Count());
		}
	}
}