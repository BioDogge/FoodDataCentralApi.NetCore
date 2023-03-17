namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class QueryForFoodInfoOptions
	{
		public int FdcId { get; set; }

		public string Format { get; set; } = "abridged";

		public List<int> Nutrients { get; set; } = new List<int>();
	}
}