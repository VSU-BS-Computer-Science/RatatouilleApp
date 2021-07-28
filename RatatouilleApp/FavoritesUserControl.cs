using RatatouilleApp.CustomControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RatatouilleApp
{
    public partial class FavoritesUserControl : UserControl
    {
        private readonly MainForm parent;

        /// <summary>
        /// FavoritesUserControl Constructor
        /// </summary>
        /// <param name="parent">Parent Form where this is called from.</param>
        public FavoritesUserControl(MainForm parent)
        {
            this.parent = parent;

            InitializeComponent();
            DisplayFavorites();
        }

        /// <summary>
        /// Displays Favorite Recipes
        /// </summary>
        private void DisplayFavorites()
        {
            RecipeBank bank = RecipeBank.GetInstance();
            List<Recipe> recipe_list = bank.GetFavoriteRecipes(); // Get Favorite Recipes from the RecipeBank

            if (recipe_list.Count > 0)
            {
                foreach (Recipe recipe in recipe_list)
                {
                    RecipeCard rc = new RecipeCard(recipe, this.parent);
                    this.favorites_panel.Controls.Add(rc);

                    rc.heart.Click += new EventHandler(this.RefreshForm);
                    rc.name.Click += new EventHandler(this.RefreshForm);
                }
            }
            else
            {
                Label lbl = new Label
                {
                    Text = "You currently have 0 favorite recipes.",
                    AutoSize = true,
                };
                this.favorites_panel.Controls.Add(lbl);
            }
        }

        /// <summary>
        /// Calls Parent Method Refresh() to refresh form contents
        /// </summary>
        private void RefreshForm(object sender, EventArgs e)
        {
            this.parent.Refresh();
        }
    }
}
