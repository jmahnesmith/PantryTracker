using NutritionixLib.Models;
using PantryDBLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace PantryDBLibrary.DataTunnel
{
    public class PantryDataTunnel
    {
        public string ConnectionString { get; private set; }
        public PantryDataTunnel(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public async Task AddFoodAsync(Foods.Food food)
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

            string sql = "[Foods_AddFood]";

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new
                {
                    upc = newFood.upc,
                    food_name = newFood.food_name,
                    brand_name = newFood.brand_name,
                    serving_qty = newFood.serving_qty,
                    serving_unit = newFood.serving_unit,
                    serving_weight_grams = newFood.serving_weight_grams,
                    calories = newFood.calories,
                    total_fat = newFood.total_fat,
                    saturated_fat = newFood.saturated_fat,
                    cholesterol = newFood.cholesterol,
                    sodium = newFood.sodium,
                    total_carbohydrate = newFood.total_carbohydrate,
                    dietary_fiber = newFood.dietary_fiber,
                    sugars = newFood.sugars,
                    protien = newFood.protien,
                    potassium = newFood.potassium,
                    tags = newFood.tags,
                    photo = newFood.photo
                };

                await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
    }
}
