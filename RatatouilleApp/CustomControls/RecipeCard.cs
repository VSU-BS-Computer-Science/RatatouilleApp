using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RatatouilleApp.CustomControls
{
    class RecipeCard : Panel
    {
        private MainForm _parent;
        private int recipe_id;
        private PictureBox pic;
        public PictureBox heart;
        public TextBox name;
        private bool isFavorite;

        public RecipeCard(Recipe recipe, MainForm parent)
        {
            this.recipe_id = recipe.RecipeID;
            this._parent = parent;
            this.isFavorite = recipe.Isfavorite;
            string path = "Temp\\" + recipe.ImagePath;
            if (!File.Exists(path))
            {
                path = "Images\\" + recipe.ImagePath;
                if (!File.Exists(path))
                {
                    path = "Images\\default";
                }
            }
            Bitmap bmp = new Bitmap(path);

            this.pic = new PictureBox
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(188, 95),
                Dock = DockStyle.Top,
                Margin = new Padding(5),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = bmp,
            };

            this.name = new TextBox
            {
                Location = new Point(10, 110),
                Size = new Size(140, 39),
                BackColor = Color.White,
                Font = new Font("Sofia Pro Light", 8, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(0),
                ReadOnly = true,
                MaxLength = 500,
                Multiline = true,
                Text = recipe.Name,
                Cursor = Cursors.Hand,
                TextAlign = HorizontalAlignment.Center,
            };

            this.heart = new PictureBox
            {
                Location = new Point(174, 113),
                Size = new Size(24, 24),
                BackColor = Color.White,
                Image = (this.isFavorite) ? Properties.Resources.heart_2 : Properties.Resources.heart_2_2,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
            };

            this.Size = new Size(210, 150);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font("Sofia Pro Light", 12, FontStyle.Regular);
            this.Margin = new Padding(0, 10, 30, 5);
            this.Padding = new Padding(10);

            this.Controls.Add(this.pic);
            this.Controls.Add(this.name);
            this.Controls.Add(this.heart);

            this.name.Click += new EventHandler(this.RecipeNameOnClicked);
            this.name.MouseLeave += new EventHandler(this.RecipeNameOnLeave);
            this.name.MouseHover += new EventHandler(this.RecipeNameOnHover);

            this.heart.Click += new EventHandler(this.HeartOnClicked);
        }

        private void HeartOnClicked(object sender, EventArgs e)
        {
            RecipeBank bank = RecipeBank.GetInstance();
            bank.UpdateRecipeFavoriteStatus(this.recipe_id, !isFavorite);
            if (this.isFavorite)
            {
                this.heart.Image = Properties.Resources.heart_2_2;
                this.isFavorite = false;
                MessageBox.Show(this.name.Text + " is removed from favorites.", "Alert!");
            }
            else
            {
                this.heart.Image = Properties.Resources.heart_2;
                this.isFavorite = true;
                MessageBox.Show(this.name.Text + " is added to favorites.", "Alert!");
            }
        }

        private void RecipeNameOnClicked(object sender, EventArgs e)
        {
            ViewRecipeForm vr = new ViewRecipeForm(this.recipe_id);
            vr.ShowDialog(_parent);
        }

        private void RecipeNameOnLeave(object sender, EventArgs e)
        {
            this.name.ForeColor = Color.Black;
            this.name.Invalidate();
        }

        private void RecipeNameOnHover(object sender, EventArgs e)
        {
            this.name.ForeColor = Color.Gray;
            this.name.Invalidate();
        }
    }
}
