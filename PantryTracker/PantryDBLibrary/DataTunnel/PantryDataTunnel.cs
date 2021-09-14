using NutritionixLib.Models;
using PantryDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PantryDBLibrary.DataTunnel
{
    public class PantryDataTunnel
    {
        public void AddFood(Foods.Food food)
        {
            Food newFood = new Food(
                food.upc,
                food.food_name,
                food.brand_name,
                food.serving_qty,
                food.serving_unit,
                food.serving_weight_grams,
                food.nf_calories,
                food.nf_total_fat,
                food.nf_saturated_fat,
                food.nf_cholesterol,
                food.nf_sodium,
                food.nf_total_carbohydrate,
                food.nf_dietary_fiber,
                food.nf_sugars,
                food.nf_protein,
                food.nf_potassium,
                food.tags.ToString(),
                food.photo.thumb);


        }
    }
}
