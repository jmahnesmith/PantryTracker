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
        private HttpClient httpClient = new HttpClient();

        private string itemURL = "https://trackapi.nutritionix.com/v2/search/item?upc=";

        public async Task<Foods> GetFood(string upc)
        {
            // Set up headers
            httpClient.DefaultRequestHeaders.Add("x-app-id", "1869a2db");
            httpClient.DefaultRequestHeaders.Add("x-app-key", "7fbd7d7b7b46d49f7e226c477f12e280");

            // Call endpoint
            HttpResponseMessage response = await httpClient.GetAsync(itemURL + upc);

            // Reset headers
            httpClient.DefaultRequestHeaders.Clear();

            response.EnsureSuccessStatusCode();

            // Deserialize Object
            var food = JsonConvert.DeserializeObject<Foods>(await response.Content.ReadAsStringAsync());

            return food;
        }
    }
}
