using FoodDataCentralApi.NetCore.Extensions;
using FoodDataCentralApi.NetCore.Models.FoodModels;
using FoodDataCentralApi.NetCore.Models.SearchModels;

namespace FoodDataCentralApi.NetCore.Services
{
	public class FoodService : IFoodService, IDisposable
	{
		private readonly Uri _searchUrl = new Uri("/fdc/v1/foods/search", UriKind.Relative);
		private readonly Uri _foodInfoUrl = new Uri("/fdc/v1/food", UriKind.Relative);

		private readonly string _apiKey;
		private readonly HttpClient _client;

		private List<KeyValuePair<string, string>> ParametersDictionary = new List<KeyValuePair<string, string>>();

		public FoodService(string apiKey)
        {
			_client = new HttpClient()
			{
				BaseAddress = new Uri("https://api.nal.usda.gov")
			};

			_apiKey = apiKey;
		}

		private void AddParametersToDictionaryForSearch(OptionsForSearchAllFood options)
		{
			ParametersDictionary.Add(new KeyValuePair<string, string>("api_key", _apiKey));
			ParametersDictionary.Add(new KeyValuePair<string, string>("query", options.Query));
			ParametersDictionary.Add(new KeyValuePair<string, string>("dataType", options.DataType));
			ParametersDictionary.Add(new KeyValuePair<string, string>("pageSize", options.PageSize.ToString()));
			ParametersDictionary.Add(new KeyValuePair<string, string>("pageNumber", options.PageNumber.ToString()));
			ParametersDictionary.Add(new KeyValuePair<string, string>("sortBy", options.SortBy));
			ParametersDictionary.Add(new KeyValuePair<string, string>("sortOrder", options.SortOrder));
		}

		private void AddParametersToDictionaryForFoodInfo(OptionsForFoodInfoQuery options)
		{
			ParametersDictionary.Add(new KeyValuePair<string, string>("api_key", _apiKey));
			ParametersDictionary.Add(new KeyValuePair<string, string>("format", options.Format));

			if (options.Nutrients.Count != 0)
			{
				foreach (var nutrient in options.Nutrients)
				{
					ParametersDictionary.Add(new KeyValuePair<string, string>("nutrients", nutrient.ToString()));
				}
			}
		}

		public async Task<FoodAndNutrientsResult> GetInformationAboutFood(OptionsForFoodInfoQuery options)
		{
			if (ParametersDictionary.Count != 0)
				ParametersDictionary.Clear();

			AddParametersToDictionaryForFoodInfo(options);
			var fdcId = options.FdcId;

			var requestUrl = new Uri($"{_foodInfoUrl}/{fdcId}?{ParametersDictionary.ConcatenateParametersToStringQuery()}", UriKind.Relative);

			var responseMessage = await _client.GetAsync(requestUrl);

			if (!responseMessage.IsSuccessStatusCode)
				throw new HttpRequestException("Error receiving data from server.");

			string responseToString = await responseMessage.Content.ReadAsStringAsync();

			var result = ResultFromJson.ConvertFromJson<FoodAndNutrientsResult>(responseToString);

			return result;
		}

		public async Task<SearchAllFoodResult> SearchFoodAsync(OptionsForSearchAllFood options)
		{
			if (ParametersDictionary.Count != 0)
				ParametersDictionary.Clear();

			AddParametersToDictionaryForSearch(options);

			var requestUrl = new Uri($"{_searchUrl}?{ParametersDictionary.ConcatenateParametersToStringQuery()}", UriKind.Relative);

			var responseMessage = await _client.GetAsync(requestUrl);

			if (!responseMessage.IsSuccessStatusCode)
				throw new HttpRequestException("Error receiving data from server.");

			string responseToString = await responseMessage.Content.ReadAsStringAsync();

			var result = ResultFromJson.ConvertFromJson<SearchAllFoodResult>(responseToString);

			return result;
		}

		public void Dispose()
		{
			_client.Dispose();
		}
	}
}