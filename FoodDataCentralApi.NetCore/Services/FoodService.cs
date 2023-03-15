using FoodDataCentralApi.NetCore.Extensions;
using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;
using Newtonsoft.Json;

namespace FoodDataCentralApi.NetCore.Services
{
	public class FoodService : IFoodService, IDisposable
	{
		private readonly Uri _searchUrl = new Uri("/fdc/v1/foods/search", UriKind.Relative);
		private readonly HttpClient _client;

		private List<KeyValuePair<string, string>> ParametersDictionary = new List<KeyValuePair<string, string>>();

		public FoodService(string apiKey)
        {
			_client = new HttpClient()
			{
				BaseAddress = new Uri("https://api.nal.usda.gov")
			};

			ParametersDictionary.Add(new KeyValuePair<string, string>("api_key", apiKey));
		}

		private void AddParametersToDictionary(QueryForSearchOptions options)
		{
			ParametersDictionary.Add(new KeyValuePair<string, string>("query", options.Query));
			ParametersDictionary.Add(new KeyValuePair<string, string>("dataType", options.DataType));
			ParametersDictionary.Add(new KeyValuePair<string, string>("pageSize", options.PageSize.ToString()));
			ParametersDictionary.Add(new KeyValuePair<string, string>("pageNumber", options.PageNumber.ToString()));
			ParametersDictionary.Add(new KeyValuePair<string, string>("sortBy", options.SortBy));
			ParametersDictionary.Add(new KeyValuePair<string, string>("sortOrder", options.SortOrder));
		}

		public async Task<FoodAndNutrientsResult> GetInformationAboutFood(QueryForFoodInfoOptions options)
		{
			throw new NotImplementedException();
		}

		public async Task<SearchFoodResult> SearchFoodAsync(QueryForSearchOptions options)
		{
			AddParametersToDictionary(options);

			var requestUrl = new Uri($"{_searchUrl}?{ParametersDictionary.ConcatenateParametersToStringQuery()}", UriKind.Relative);

			var responseMessage = await _client.GetAsync(requestUrl);

			if (!responseMessage.IsSuccessStatusCode)
				throw new HttpRequestException("Error receiving data from server.");

			string responseToString = await responseMessage.Content.ReadAsStringAsync();

			var result = ResultFromJson.ConvertFromJson<SearchFoodResult>(responseToString);

			return result;
		}

		public void Dispose()
		{
			_client.Dispose();
		}
	}
}