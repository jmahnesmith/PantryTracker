using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionixLib.Models
{
    public class FullNutrient
    {
        public FullNutrient(
            int attrId,
            double value
        )
        {
            this.AttrId = attrId;
            this.Value = value;
        }

        public int AttrId { get; }
        public double Value { get; }
    }
}
