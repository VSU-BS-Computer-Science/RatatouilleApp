using System;
using System.Drawing;
using System.Windows.Forms;

namespace RatatouilleApp
{
    public partial class MainForm : Form
    {
        private int active_menu_button = 1;

        /// <summary>
        /// MainForm Constructor
        /// </summary>
        public MainForm()
        {
            RecipeBank.ReadObject(); // Reads data from local repository
            
            InitializeComponent();
            ShowHomeForm();

            /*Recipe recipe = new Recipe(2, "", "Chicken sRecipe", 30, "mins.", 12, "Blah", "Blah");
            RecipeBank bank = RecipeBank.GetInstance();
            bank.AddRecipe(recipe);
            RecipeBank.WriteObject();*/
        }

        /// <summary>
        /// Clears the control_panel Controls and adds the newly created HomeForm
        /// </summary>
        public void ShowHomeForm()
        {
            GC.Collect();
            control_panel.Controls.Clear();

            HomeUserControl hf = new HomeUserControl(this);
            control_panel.Controls.Add(hf);
        }

        /// <summary>
        /// Clears the control_panel Controls and adds the newly created RecipesForm
        /// </summary>
        public void ShowRecipesForm()
        {
            GC.Collect();
            control_panel.Controls.Clear();

            RecipesUserControl rf = new RecipesUserControl(this);
            control_panel.Controls.Add(rf);
        }

        /// <summary>
        /// Clears the control_panel Controls and adds the newly created FavoritesForm
        /// </summary>
        public void ShowFavoritesForm()
        {
            GC.Collect();
            control_panel.Controls.Clear();

            FavoritesUserControl ff = new FavoritesUserControl(this);
            control_panel.Controls.Add(ff);
        }

        #region Menu Button Click Events

        /// <summary>
        /// home_menubtn Click Event
        /// </summary>
        private void HomeMenuButtonOnClicked(object sender, EventArgs e)
        {
            active_menu_button = 1;
            home_menubtn.BackColor = Color.FromArgb(164, 51, 13);
            home_menubtn.ForeColor = Color.White;

            recipes_menubtn.BackColor = Color.FromArgb(233, 176, 142);
            recipes_menubtn.ForeColor = Color.Black;

            favorites_menubtn.BackColor = Color.FromArgb(233, 176, 142);
            favorites_menubtn.ForeColor = Color.Black;

            ShowHomeForm();
        }

        /// <summary>
        /// recipes_menubtn Click Event
        /// </summary>
        public void RecipesMenuButtonOnClicked(object sender, EventArgs e)
        {
            active_menu_button = 2;
            home_menubtn.BackColor = Color.FromArgb(233, 176, 142);
            home_menubtn.ForeColor = Color.Black;

            recipes_menubtn.BackColor = Color.FromArgb(164, 51, 13);
            recipes_menubtn.ForeColor = Color.White;

            favorites_menubtn.BackColor = Color.FromArgb(233, 176, 142);
            favorites_menubtn.ForeColor = Color.Black;

            ShowRecipesForm();
        }

        public void FavoritesMenuButtonOnClicked(object sender, EventArgs e)
        {
            active_menu_button = 3;
            home_menubtn.BackColor = Color.FromArgb(233, 176, 142);
            home_menubtn.ForeColor = Color.Black;

            recipes_menubtn.BackColor = Color.FromArgb(233, 176, 142);
            recipes_menubtn.ForeColor = Color.Black;

            favorites_menubtn.BackColor = Color.FromArgb(164, 51, 13);
            favorites_menubtn.ForeColor = Color.White;

            ShowFavoritesForm();
        }

        #endregion

        /// <summary>
        /// MainForm OnClosing Event, Shows a MessageBox for confirmation
        /// </summary>
        private void MainFormOnClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?\nNOTE: All changes will be saved!",
                               "Confirmation",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
                RecipeBank.WriteObject(); // Saves the data to the local repository
            }
        }


        /// <summary>
        /// Overrides Refresh Method and checks for active_menu_button
        /// </summary>
        override
        public void Refresh()
        {
            switch (active_menu_button)
            {
                case 1:
                    ShowHomeForm();
                    break;
                case 2:
                    ShowRecipesForm();
                    break;
                case 3:
                    ShowFavoritesForm();
                    break;
            }
        }
    }
}
