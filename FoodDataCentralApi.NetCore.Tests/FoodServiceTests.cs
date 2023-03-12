using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDataCentralApi.NetCore.Tests
{
	public class FoodServiceTests
	{
		[Fact]
		public async Task FoodServiceTest()
		{
			UsdaClient usdaClient = new UsdaClient("DEMO_KEY");
			var result = await usdaClient.SearchResultAsync(new Models.SearchModels.QueryForSearchOptions
			{
				Query = "apple"
			});
		}
	}
}