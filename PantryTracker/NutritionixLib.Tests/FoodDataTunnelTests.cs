using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NutritionixLib.DataTunnel;
using Xunit;

namespace NutritionixLib.Tests
{
    public class FoodDataTunnelTests
    {
        [Fact]
        public async Task GetFood_ReturnDietPepsiAsync()
        {
            var expected = "Diet Cola";

            var foodDataTunnel = new FoodDataTunnel();

            var actual = await foodDataTunnel.GetFood("012000171741");

            var actualName = actual.foods[0].food_name;

            Assert.Equal(expected, actualName);
        }
    }
}
