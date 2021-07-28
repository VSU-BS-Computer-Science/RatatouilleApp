using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RatatouilleApp.CustomControls
{
    class RecipeBox : FlowLayoutPanel
    {
        private readonly MainForm parent;
        private readonly int recipe_id;
        private readonly PictureBox pic;
        private readonly TableLayoutPanel tbl;
        private readonly Label name;
        private readonly Label time;
        private readonly Label servings;
        private readonly Label keywords;
        private bool isFavorite;
        public PictureBox heart;

        public RecipeBox(Recipe recipe, bool withKeyword, MainForm parent)
        {
            this.recipe_id = recipe.RecipeID;
            this.parent = parent;
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

            this.pic = new PictureBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                ErrorImage = Properties.Resources.ic_restaurant_menu_24px,
                Image = bmp,
                Size = new Size(155, 85),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            this.heart = new PictureBox
            {
                Size = new Size(24, 24),
                BackColor = Color.White,
                Image = (this.isFavorite) ? Properties.Resources.heart_2 : Properties.Resources.heart_2_2,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
            };

            this.tbl = new TableLayoutPanel()
            {
                Margin = new Padding(5,15,5,5),
                ColumnCount = 4,
                RowCount = 2,
                Size = new Size(540, 70),
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize,
            };

            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            this.tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));

            this.tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            this.tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50));


            this.name = new Label()
            {
                Text = recipe.Name,
                Font = new Font("Sofia Pro", 12, FontStyle.Regular),
                AutoSize = true,
                Cursor = Cursors.Hand,
            };
            

            this.time = new Label()
            {
                Text = "Cooking Time: " + recipe.TimeValue + " " + recipe.TimeUnit + "",
                AutoSize = true,
                Font = new Font("Sofia Pro Light", 9, FontStyle.Regular),
            };

            this.servings = new Label()
            {
                Text = "Servings: " + recipe.NumOfServings.ToString(),
                AutoSize = true,
                Font = new Font("Sofia Pro Light", 9, FontStyle.Regular),
            };

            if (withKeyword)
            {
                this.keywords = new Label()
                {
                    Text = "Keywords Matched: " + recipe.KeywordsFound,
                    AutoSize = true,
                    Font = new Font("Sofia Pro Light", 9, FontStyle.Regular),
                };
                this.tbl.Controls.Add(this.keywords, 2, 1);
            }
            

            this.tbl.Controls.Add(this.name, 0, 0);
            this.tbl.Controls.Add(this.time, 0, 1);
            this.tbl.Controls.Add(this.servings, 1, 1);
            this.tbl.Controls.Add(this.heart, 3, 0);

            this.tbl.SetColumnSpan(this.name, 3);

            this.BorderStyle = BorderStyle.FixedSingle;
            this.AutoSize = true;
            this.Margin = new Padding(5);

            this.Controls.Add(this.pic);
            this.Controls.Add(this.tbl);


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

        private void RecipeNameOnClicked(object sender, EventArgs e)
        {
            ViewRecipeForm vr = new ViewRecipeForm(this.recipe_id);
            vr.ShowDialog(parent);
        }
    }
}
