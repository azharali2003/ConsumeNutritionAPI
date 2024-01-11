using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consumeAPI_SUN.Models
{
    public class Nutrient
    {
        public string Label { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class ParsedIngredient
    {
        public double Quantity { get; set; }
        public string Measure { get; set; }
        public string FoodMatch { get; set; }
        public string Food { get; set; }
    }
    public class IngredientSection
    {
        public List<ParsedIngredient> Parsed { get; set; }
    }
   
    public class FoodInfo
    {
        public int Qty { get; set; }

        public string Unit { get; set; }
        public string text { get; set; }
        
        public double calories { get; set; }
        public double Weight { get; set; }
        public double totalWeight { get; set; }
        public Dictionary<string, Nutrient> TotalNutrients { get; set; }
        

        public double Magnesium { get; set; }
        public double MG { get; set; }
        public  float calcium { get; set; }
        public List<IngredientSection> Ingredients { get; set; }
       


    }
}