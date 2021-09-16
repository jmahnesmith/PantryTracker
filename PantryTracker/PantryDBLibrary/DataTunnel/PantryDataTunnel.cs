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

        public async Task AddFoodAsync(Food food)
        {
            string sql = "[Foods_AddFood]";

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                var parameters = new
                {
                    upc =  food.upc,
                    food_name =  food.food_name,
                    brand_name =  food.brand_name,
                    serving_qty =  food.serving_qty,
                    serving_unit =  food.serving_unit,
                    serving_weight_grams =  food.serving_weight_grams,
                    calories =  food.calories,
                    total_fat =  food.total_fat,
                    saturated_fat =  food.saturated_fat,
                    cholesterol =  food.cholesterol,
                    sodium =  food.sodium,
                    total_carbohydrate =  food.total_carbohydrate,
                    dietary_fiber =  food.dietary_fiber,
                    sugars =  food.sugars,
                    protien =  food.protien,
                    potassium =  food.potassium,
                    tags =  food.tags,
                    photo =  food.photo
                };

                await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
            }
        }
    }
}
