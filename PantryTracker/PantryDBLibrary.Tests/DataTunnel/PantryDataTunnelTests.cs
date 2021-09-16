using PantryDBLibrary.DataTunnel;
using PantryDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PantryDBLibrary.Tests.DataTunnel
{
    public class PantryDataTunnelTests
    {
        [Fact]
        public async Task AddFoodAsync_TestAdd()
        {
            Food food = new Food(
                1234684,
                "Bepis",
                "Bonkes",
                1,
                "Boodle",
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                1,
                "Lit yo",
                "www.foodpic.com/bepis" 
                );

            PantryDataTunnel pantryDataTunnel = new PantryDataTunnel(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PantryDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            await pantryDataTunnel.AddFoodAsync(food);

            var test = "yes";
        }
    }
}
