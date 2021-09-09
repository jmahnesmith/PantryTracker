using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionixLib.Models
{
    public class Food
    {
        public Food(
            string foodName,
            string brandName,
            double servingQty,
            string servingUnit,
            object servingWeightGrams,
            int nfCalories,
            int nfTotalFat,
            int nfSaturatedFat,
            int nfCholesterol,
            int nfSodium,
            int nfTotalCarbohydrate,
            int nfDietaryFiber,
            int nfSugars,
            int nfProtein,
            object nfPotassium,
            object nfP,
            string nixBrandName,
            string nixBrandId,
            string nixItemName,
            string nixItemId,
            Metadata metadata,
            int source,
            object ndbNo,
            object tags,
            object altMeasures,
            Photo photo
        )
        {
            this.FoodName = foodName;
            this.BrandName = brandName;
            this.ServingQty = servingQty;
            this.ServingUnit = servingUnit;
            this.ServingWeightGrams = servingWeightGrams;
            this.NfCalories = nfCalories;
            this.NfTotalFat = nfTotalFat;
            this.NfSaturatedFat = nfSaturatedFat;
            this.NfCholesterol = nfCholesterol;
            this.NfSodium = nfSodium;
            this.NfTotalCarbohydrate = nfTotalCarbohydrate;
            this.NfDietaryFiber = nfDietaryFiber;
            this.NfSugars = nfSugars;
            this.NfProtein = nfProtein;
            this.NfPotassium = nfPotassium;
            this.NfP = nfP;
            this.NixBrandName = nixBrandName;
            this.NixBrandId = nixBrandId;
            this.NixItemName = nixItemName;
            this.NixItemId = nixItemId;
            this.Metadata = metadata;
            this.Source = source;
            this.NdbNo = ndbNo;
            this.Tags = tags;
            this.AltMeasures = altMeasures;
            this.Photo = photo;
        }

        public string FoodName { get; }
        public string BrandName { get; }
        public double ServingQty { get; }
        public string ServingUnit { get; }
        public object ServingWeightGrams { get; }
        public int NfCalories { get; }
        public int NfTotalFat { get; }
        public int NfSaturatedFat { get; }
        public int NfCholesterol { get; }
        public int NfSodium { get; }
        public int NfTotalCarbohydrate { get; }
        public int NfDietaryFiber { get; }
        public int NfSugars { get; }
        public int NfProtein { get; }
        public object NfPotassium { get; }
        public object NfP { get; }
        public IReadOnlyList<FullNutrient> FullNutrients { get; }
        public string NixBrandName { get; }
        public string NixBrandId { get; }
        public string NixItemName { get; }
        public string NixItemId { get; }
        public Metadata Metadata { get; }
        public int Source { get; }
        public object NdbNo { get; }
        public object Tags { get; }
        public object AltMeasures { get; }
        public Photo Photo { get; }
    }
}
