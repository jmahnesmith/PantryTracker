using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionixLib.Models
{
    public class Foods
    {
        public Foods(List<Food> foods)
        {
            this.FoodsList = foods;
        }

        public IReadOnlyList<Food> FoodsList { get; }
    }
}
