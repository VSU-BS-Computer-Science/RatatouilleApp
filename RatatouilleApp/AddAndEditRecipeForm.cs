using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RatatouilleApp
{
    public partial class AddAndEditRecipeForm : Form
    {
        private readonly int recipe_id;

        /// <summary>
        /// AddAndEditRecipeForm Constructor, called when adding new recipe
        /// </summary>
        public AddAndEditRecipeForm()
        {
            InitializeComponent();

            this.img_location_lbl.Text = "";
            this.img_location_lbl.Visible = false;
            this.save_btn.Visible = false;
        }

        /// <summary>
        /// AddAndEditRecipeForm Constructor, called when editing recipe
        /// </summary>
        /// <param name="recipe_id">RecipeID of the recipe to be display.</param>
        public AddAndEditRecipeForm(int recipe_id)
        {
            this.recipe_id = recipe_id;
            InitializeComponent();

            this.img_location_lbl.Text = "";
            this.img_location_lbl.Visible = false;

            DisplayRecipeDetails();
        }

        /// <summary>
        /// Displays Recipe Details
        /// </summary>
        private void DisplayRecipeDetails()
        {
            /// Get the instance of the RecipeBank
            RecipeBank bank = RecipeBank.GetInstance();
            Recipe recipe = bank.GetRecipeWithID(this.recipe_id);

            this.add_btn.Visible = false;
            this.name_textbox.Text = recipe.Name;
            this.time_numeric_updown.Value = recipe.TimeValue;
            this.time_combobox.Text = recipe.TimeUnit;
            this.servings_numeric_updown.Value = recipe.NumOfServings;
            this.ingredients_textbox.Text = recipe.Ingredients;
            this.procedure_textbox.Text = recipe.Procedure;

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
        /// Choose Image Link Clicked Event
        /// </summary>
        private void ChooseImageLinkOnClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /// Shows a OpenFileDialog with a filter for images extensions
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new(ofd.FileName);
                FillPictureBox(recipe_picturebox, bmp);
                img_location_lbl.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// Add Button Clicked Event
        /// </summary>
        private void AddButtonOnClicked(object sender, EventArgs e)
        {
            /// Get the instance of the RecipeBank
            RecipeBank bank = RecipeBank.GetInstance();

            string error_msg = "";

            /// Checks if the name_textbox is empty
            if (this.name_textbox.Text == "")
                error_msg = "Recipe Name should not be empty.\n";

            /// Checks if the recipe name already exists
            if (bank.IsRecipeWithNameExists(this.name_textbox.Text))
                error_msg = "Recipe Name already exist.\n";
            
            /// If there are no errors found
            if (error_msg == "")
            {
                /// Generates new RecipeID using a method from RecipeBank and stores it in a local variable
                int new_recipe_id = bank.GenerateNewRecipeID();

                /// Creates a new recipe base on the given values
                Recipe new_recipe = new(
                    new_recipe_id,
                    (this.img_location_lbl.Text == "") ? "" : new_recipe_id.ToString(),
                    this.name_textbox.Text,
                    (int)this.time_numeric_updown.Value,
                    this.time_combobox.SelectedItem.ToString(),
                    (int)this.servings_numeric_updown.Value,
                    this.ingredients_textbox.Text,
                    this.procedure_textbox.Text);

                /// Adds the new recipe to the RecipeBank
                bank.AddRecipe(new_recipe);

                MessageBox.Show("New Recipe Added Successfully!", "Alert");
                
                string path = "Temp\\" + new_recipe_id;

                /// Checks if an image file has been choosed
                if (!(this.img_location_lbl.Text == ""))
                {
                    this.Dispose();
                    File.Copy(this.img_location_lbl.Text, path); /// Copies the image file to Temp folder
                }
            }
            else
            {
                MessageBox.Show(error_msg, "Error Message");
            }
        }

        /// <summary>
        /// Save Button Clicked Event
        /// </summary>
        private void SaveButtonOnClicked(object sender, EventArgs e)
        {
            RecipeBank bank = RecipeBank.GetInstance();

            /*int count = 1;
            string path = "Temp\\";
            string newPath = path + this.name_textbox.Text;

            while (File.Exists(newPath))
            {
                string temp = string.Format("{0}({1})", this.name_textbox.Text, count++);
                newPath = Path.Combine(path, temp);
            }*/

            string error_msg = "";

            // Checks if the name_textbox is empty
            if (this.name_textbox.Text == "")
                error_msg = "Recipe Name should not be empty.\n";

            /// Checks if the recipe name already exists
            if (bank.IsRecipeWithNameExists(this.name_textbox.Text, this.recipe_id))
                error_msg = "Recipe Name already exist.\n";

            /// If there are no errors found
            if (error_msg == "")
            {
                /// Creates a new recipe base on the given values
                Recipe recipe = new(
                    this.recipe_id,
                    (this.img_location_lbl.Text == "") ? "" : this.recipe_id.ToString(),
                    this.name_textbox.Text,
                    (int)this.time_numeric_updown.Value,
                    this.time_combobox.SelectedItem.ToString(),
                    (int)this.servings_numeric_updown.Value,
                    this.ingredients_textbox.Text,
                    this.procedure_textbox.Text);

                /// Updates the recipe with the RecipeID in the RecipeBank
                bank.UpdateRecipeWithID(this.recipe_id, recipe);

                MessageBox.Show("Recipe Updated Successfully!", "Alert");

                string path = "Temp\\" + this.recipe_id;

                /// Checks if an image file has been choosed
                if (!(this.img_location_lbl.Text == ""))
                {
                    this.Dispose();
                    File.Copy(this.img_location_lbl.Text, path, true); /// Copies the image file to Temp folder
                }
            }
            else
            {
                MessageBox.Show(error_msg, "Error Message");
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
