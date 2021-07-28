using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RatatouilleApp
{
    public partial class ViewRecipeForm : Form
    {
        private readonly int recipe_id;
        private string path;
        private bool isFavorite;

        /// <summary>
        /// ViewRecipeForm Constructor, called when viewing a recipe
        /// </summary>
        public ViewRecipeForm(int recipe_id)
        {
            this.recipe_id = recipe_id;

            InitializeComponent();
            DisplayRecipeDetails();
        }

        /// <summary>
        /// Displays Recipe Details
        /// </summary>
        private void DisplayRecipeDetails()
        {
            RecipeBank bank = RecipeBank.GetInstance();

            bank.AddRecipeToRecentlyViewed(recipe_id);
            Recipe recipe = bank.GetRecipeWithID(recipe_id);

            this.path = recipe.ImagePath;
            this.isFavorite = recipe.Isfavorite;
            this.heart_btn.Image = (this.isFavorite) ? Properties.Resources.heart_2 : Properties.Resources.heart_2_2;
            this.recipe_name.Text = recipe.Name;
            this.recipe_time.Text = "Cooking Time: " + recipe.TimeValue + " " + recipe.TimeUnit;
            this.recipe_servings.Text = "Servings: " + recipe.NumOfServings.ToString();
            this.recipe_ingredients.Text = recipe.Ingredients;
            this.recipe_procedure.Text = recipe.Procedure;

            this.heart_btn.Click += new EventHandler(this.HeartOnClicked);

            /// Checks for the image of the recipe to be used
            /// First path to be check is the Temp folder
            /// Then, Images folder
            /// Else, default image will be shown
            string path = "Temp\\" + recipe.ImagePath;
            if (!File.Exists(path))
            {
                path = "Images\\" + recipe.ImagePath;
                if (!File.Exists(path))
                    path = "Images\\default";
            }
            Bitmap bmp = new(path);
            FillPictureBox(this.recipe_picturebox, bmp);
        }

        /// <summary>
        /// Heart Clicked Event
        /// </summary>
        private void HeartOnClicked(object sender, EventArgs e)
        {
            RecipeBank bank = RecipeBank.GetInstance();
            bank.UpdateRecipeFavoriteStatus(this.recipe_id, !isFavorite);
            if (this.isFavorite)
            {
                this.heart_btn.Image = Properties.Resources.heart_2_2;
                this.isFavorite = false;
                MessageBox.Show(this.recipe_name.Text + " is removed from favorites.", "Alert!");
            }
            else
            {
                this.heart_btn.Image = Properties.Resources.heart_2;
                this.isFavorite = true;
                MessageBox.Show(this.recipe_name.Text + " is added to favorites.", "Alert!");
            }
            this.Owner.Refresh();
        }

        /// <summary>
        /// Edit Button Clicked Event
        /// </summary>
        private void EditButtonOnClicked(object sender, EventArgs e)
        {
            this.Close();
            AddAndEditRecipeForm ar = new AddAndEditRecipeForm(this.recipe_id);
            ar.ShowDialog(this.Owner);
            this.Owner.Refresh();
        }

        /// <summary>
        /// Delete Button Clicked Event
        /// </summary>
        private void DeleteButtonOnClicked(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to this recipe?",
                               "Confirmation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                RecipeBank bank = RecipeBank.GetInstance();
                if (bank.GetRecipes().Count > 1)
                {
                    bank.DeleteRecipeWithID(this.recipe_id);
                    bank.AddImagePathToDeletedRecipesImageList(path);
                    MessageBox.Show("Recipe Deleted Successfully!", "Message");
                    this.Close();
                    this.Owner.Refresh();
                }
                else
                {
                    MessageBox.Show("Can't delete! This is the last recipe.\nNote: Recipe List should not be empty.", "Alert!");
                }
            }
        }

        /// <summary>
        /// Called to display an image on a PictureBox
        /// </summary>
        /// <param name="pbox">PictureBox to be filled.</param>
        /// <param name="bmp">Bitmap to be displayed.</param>
        static public void FillPictureBox(PictureBox pbox, Bitmap bmp)
        {
            pbox.SizeMode = PictureBoxSizeMode.Normal;
            bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pbox.Width / pbox.Height;

            var resized = new Bitmap(pbox.Width, pbox.Height);
            var g = Graphics.FromImage(resized);
            var dest_rect = new Rectangle(0, 0, pbox.Width, pbox.Height);
            Rectangle src_rect;

            if (source_is_wider)
            {
                float size_ratio = (float)pbox.Height / bmp.Height;
                int sample_width = (int)(pbox.Width / size_ratio);
                src_rect = new Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
            }
            else
            {
                float size_ratio = (float)pbox.Width / bmp.Width;
                int sample_height = (int)(pbox.Height / size_ratio);
                src_rect = new Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
            }

            g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
            g.Dispose();

            pbox.Image = resized;
        }
    }
}
