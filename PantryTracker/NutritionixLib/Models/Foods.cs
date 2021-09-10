using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionixLib.Models
{
    public class Foods
    {
        public Food[] foods { get; set; }

        public class Food
        {
            public string food_name { get; set; }
            public string brand_name { get; set; }
            public int serving_qty { get; set; }
            public string serving_unit { get; set; }
            public object serving_weight_grams { get; set; }
            public int nf_calories { get; set; }
            public int nf_total_fat { get; set; }
            public object nf_saturated_fat { get; set; }
            public object nf_cholesterol { get; set; }
            public int nf_sodium { get; set; }
            public int nf_total_carbohydrate { get; set; }
            public object nf_dietary_fiber { get; set; }
            public int nf_sugars { get; set; }
            public int nf_protein { get; set; }
            public object nf_potassium { get; set; }
            public object nf_p { get; set; }
            public Full_Nutrients[] full_nutrients { get; set; }
            public string nix_brand_name { get; set; }
            public string nix_brand_id { get; set; }
            public string nix_item_name { get; set; }
            public string nix_item_id { get; set; }
            public Metadata metadata { get; set; }
            public int source { get; set; }
            public object ndb_no { get; set; }
            public object tags { get; set; }
            public object alt_measures { get; set; }
            public object lat { get; set; }
            public object lng { get; set; }
            public Photo photo { get; set; }
            public object note { get; set; }
            public object class_code { get; set; }
            public object brick_code { get; set; }
            public object tag_id { get; set; }
            public DateTime updated_at { get; set; }
            public string nf_ingredient_statement { get; set; }
        }

        public class Metadata
        {
        }

        public class Photo
        {
            public string thumb { get; set; }
            public object highres { get; set; }
            public bool is_user_uploaded { get; set; }
        }

        public class Full_Nutrients
        {
            public int attr_id { get; set; }
            public int value { get; set; }
        }

    }
}
