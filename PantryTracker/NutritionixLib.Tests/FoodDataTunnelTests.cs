using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NutritionixLib.DataTunnel;
using NutritionixLib.Models;
using Xunit;
using static NutritionixLib.Models.Foods;

namespace NutritionixLib.Tests
{
    public class FoodDataTunnelTests
    {
        [Fact]
        public async Task GetFood_ReturnDietPepsiAsync()
        {
            string expected = "Diet Cola";

            FoodDataTunnel foodDataTunnel = new FoodDataTunnel();

            Food actual = await foodDataTunnel.GetFood("012000171741");

            string actualName = actual.food_name;

            Assert.Equal(expected, actualName);
        }
    }
}
