using System;
using System.Collections.Generic;
using System.Text;

namespace PantryDBLibrary.Models
{
    public class Food
    {
        public int upc;
        public string food_name;
        public string brand_name;
        public int serving_qty;
        public string serving_unit;
        public string serving_weight_grams;
        public int calories;
        public int total_fat;
        public int saturated_fat;
        public int cholesterol;
        public int sodium;
        public int total_carbohydrate;
        public int dietary_fiber;
        public int sugars;
        public int protien;
        public string potassium;
        public string tags;
        public string photo;
        private int? serving_qty1;
        private int? serving_weight_grams1;
        private int? nf_calories;
        private int? nf_total_fat;
        private int? nf_saturated_fat;
        private int? nf_cholesterol;
        private int? nf_sodium;
        private int? nf_total_carbohydrate;
        private int? nf_dietary_fiber;
        private int? nf_sugars;
        private int? nf_protein;
        private int? nf_potassium;
        private string v;
        private string thumb;

        public Food(int upc, string food_name, string brand_name, int? serving_qty1, string serving_unit, int? serving_weight_grams1, int? nf_calories, int? nf_total_fat, int? nf_saturated_fat, int? nf_cholesterol, int? nf_sodium, int? nf_total_carbohydrate, int? nf_dietary_fiber, int? nf_sugars, int? nf_protein, int? nf_potassium, string v, string thumb)
        {
            this.upc = upc;
            this.food_name = food_name;
            this.brand_name = brand_name;
            this.serving_qty1 = serving_qty1;
            this.serving_unit = serving_unit;
            this.serving_weight_grams1 = serving_weight_grams1;
            this.nf_calories = nf_calories;
            this.nf_total_fat = nf_total_fat;
            this.nf_saturated_fat = nf_saturated_fat;
            this.nf_cholesterol = nf_cholesterol;
            this.nf_sodium = nf_sodium;
            this.nf_total_carbohydrate = nf_total_carbohydrate;
            this.nf_dietary_fiber = nf_dietary_fiber;
            this.nf_sugars = nf_sugars;
            this.nf_protein = nf_protein;
            this.nf_potassium = nf_potassium;
            this.v = v;
            this.thumb = thumb;
        }
    }
}
