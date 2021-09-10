using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using NutritionixLib.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NutritionixLib.DataTunnel
{
    public class FoodDataTunnel
    {
        private HttpClient httpClient;

        private string itemURL = "https://trackapi.nutritionix.com/v2/search/item?upc=";

        public async Task<Foods> getFood(string upc)
        {
            HttpResponseMessage response = await httpClient.GetAsync(itemURL + upc);

            response.EnsureSuccessStatusCode();

            var food = JsonConvert.DeserializeObject<Foods>(await response.Content.ReadAsStringAsync());
            return food;
        }
    }
}
