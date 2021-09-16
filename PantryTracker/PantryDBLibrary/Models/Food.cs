using System;
using System.Collections.Generic;
using System.Text;

namespace PantryDBLibrary.Models
{
    public class Food
    {
        public int upc;
        public string? food_name;
        public string? brand_name;
        public int? serving_qty;
        public string? serving_unit;
        public int? serving_weight_grams;
        public int? calories;
        public int? total_fat;
        public int? saturated_fat;
        public int? cholesterol;
        public int? sodium;
        public int? total_carbohydrate;
        public int? dietary_fiber;
        public int? sugars;
        public int? protien;
        public int? potassium;
        public string? tags;
        public string? photo;
        public int amount;


        public Food(int upc, string? food_name, string? brand_name, int? serving_qty, string? serving_unit, int? serving_weight_grams, int? nf_calories, int? nf_total_fat, int? nf_saturated_fat, int? nf_cholesterol, int? nf_sodium, int? nf_total_carbohydrate, int? nf_dietary_fiber, int? nf_sugars, int? nf_protein, int? nf_potassium, string? tags, string? thumb)
        {
            this.upc = upc;
            this.food_name = food_name;
            this.brand_name = brand_name;
            this.serving_qty = serving_qty;
            this.serving_unit = serving_unit;
            this.serving_weight_grams = serving_weight_grams;
            this.calories = nf_calories;
            this.total_fat = nf_total_fat;
            this.saturated_fat = nf_saturated_fat;
            this.cholesterol = nf_cholesterol;
            this.sodium = nf_sodium;
            this.total_carbohydrate = nf_total_carbohydrate;
            this.dietary_fiber = nf_dietary_fiber;
            this.sugars = nf_sugars;
            this.protien = nf_protein;
            this.potassium = nf_potassium;
            this.tags = tags;
            this.photo = thumb;
        }
    }
}
