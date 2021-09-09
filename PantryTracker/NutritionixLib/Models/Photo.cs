using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionixLib.Models
{
    public class Photo
    {
        public Photo(
            string thumb,
            object highres
        )
        {
            this.Thumb = thumb;
            this.Highres = highres;
        }

        public string Thumb { get; }
        public object Highres { get; }
    }
}
