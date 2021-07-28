using RatatouilleApp.CustomControls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RatatouilleApp
{
    public partial class HomeUserControl : UserControl
    {
        private int recipe_id;
        private readonly MainForm parent;

        /// <summary>
        /// HomeUserControl Constructor
        /// </summary>
        /// <param name="parent">Parent Form where this is called from.</param>
        public HomeUserControl(MainForm parent)
        {
            this.parent = parent;

            InitializeComponent();
            DisplaySuggestedRecipe();
            DisplayRecentlyViewedRecipes();
        }

        /// <summary>
        /// Displays Recently Viewed Recipes
        /// </summary>
        private void DisplayRecentlyViewedRecipes()
        {
            RecipeBank bank = RecipeBank.GetInstance();

            foreach (Recipe recipe in bank.GetRecentlyViewedRecipes())
            {
                RecipeCard rc = new(recipe, parent);
                this.recently_viewed_panel.Controls.Add(rc);
            }
        }

        /// <summary>
        /// Displays Suggested Recipe
        /// </summary>
        private void DisplaySuggestedRecipe()
        {
            RecipeBank bank = RecipeBank.GetInstance();
            Recipe recipe_of_the_day = bank.GetRandomRecipe();

            this.recipe_id = recipe_of_the_day.RecipeID;

            /// Checks for the image of the recipe to be used
            /// First path to be check is the Temp folder
            /// Then, Images folder
            /// Else, default image will be shown
            string path = "Temp\\" + recipe_of_the_day.ImagePath;
            if (!File.Exists(path))
            {
                path = "Images\\" + recipe_of_the_day.ImagePath;
                if (!File.Exists(path))
                {
                    path = "Images\\default";
                }
            }

            Bitmap bmp = new Bitmap(path);
            suggested_recipe_img.Image = bmp;
            suggested_recipe_img.Controls.Add(shape_picturebox);

            suggested_recipe_name.Text = recipe_of_the_day.Name;

            suggested_recipe_name.Click += new EventHandler(this.SuggestedRecipeNameOnClick);
        }

        /// <summary>
        /// Suggested Recipe Name Clicked Event
        /// </summary>
        private void SuggestedRecipeNameOnClick(object sender, EventArgs e)
        {
            ViewRecipeForm vr = new(this.recipe_id);
            vr.ShowDialog(parent);
            parent.Refresh();
        }
    }
}
