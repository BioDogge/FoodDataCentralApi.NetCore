namespace FoodDataCentralApi.NetCore.Models.FoodModels
{
	public class OptionsForFoodInfoQuery
	{
		private List<int> nutrients = new List<int>() { 203, 204, 205 };

		/// <summary>
		/// FDC ID of the food to retrieve.
		/// </summary>
		public int FdcId { get; set; }

		/// <summary>
		/// Optional. Format of the returned food's information. Default is abridged.
		/// </summary>
		public string Format { get; set; } = "abridged";

		/// <summary>
		/// Optional. List of up to 25 nutrient numbers.
		/// </summary>
		public List<int> Nutrients
		{
			get
			{
				return nutrients;
			}
			set
			{
				if (value.Count <= 25)
					nutrients = value;
			}
		}
	}
}