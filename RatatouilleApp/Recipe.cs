using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatatouilleApp
{
    [Serializable]
    class Recipe
    {
        public int RecipeID { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public int TimeValue { get; set; }
        public string TimeUnit { get; set; }
        public int NumOfServings { get; set; }
        public string Ingredients { get; set; }
        public string Procedure { get; set; }
        public int KeywordsFound { get; set; }
        public bool Isfavorite { get; set; }

        public Recipe(int id, string img, string name, int time_value, string time_unit, int num, string ing, string pro)
        {
            this.RecipeID = id;
            this.ImagePath = img;
            this.Name = name;
            this.TimeValue = time_value;
            this.TimeUnit = time_unit;
            this.NumOfServings = num;
            this.Ingredients = ing;
            this.Procedure = pro;
            this.KeywordsFound = 0;
            this.Isfavorite = false;
        }
    }
}
