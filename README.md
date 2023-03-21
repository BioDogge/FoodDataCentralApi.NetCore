# FoodDataCentralApi.Net

A .NET 6.0 library for interaction with the USDA's FoodData Central API.


## How to install

Run the following command.
```
dotnet add package FoodDataCentralApi.Net --version 0.1.1-beta # or latest version
```

## How to use

Search for foods by name.
```c#
//Create the client for working with the API
UsdaClient usdaClient = new UsdaClient("YOUR_API_KEY");

//Setting up foods search
OptionsForSearchAllFood optionsForSearchAll = new OptionsForSearchAllFood()
{
    Query = "apple"
};

//Get a list of food that matched search
SearchAllFoodResult result = await usdaClient.SearchAllFoodResultAsync(optionsForSearchAll);
```
Search for foods and its nutrients by FDC ID.
```c#
//Create the client for working with the API
UsdaClient usdaClient = new UsdaClient("YOUR_API_KEY");

//Setting up search for food by id
OptionsForFoodInfoQuery  optionsForFoodInfo = new OptionsForFoodInfoQuery()
{
    FdcId = 1750340
};

//Get info about food and its nutrients
FoodAndNutrientsResult result = await usdaClient.GetInfoFoodAndNutrientsAsync(optionsForFoodInfo);
