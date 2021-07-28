using RatatouilleApp.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RatatouilleApp
{
    public partial class RecipesUserControl : UserControl
    {
        private MainForm parent;
        private AddAndEditRecipeForm addrecipe_form;
        private int keywords = 0;

        /// <summary>
        /// RecipesUserControl Constructor
        /// </summary>
        /// <param name="parent">Parent Form where this is called from.</param>
        public RecipesUserControl(MainForm parent)
        {
            this.parent = parent;

            InitializeComponent();
            DisplayRecipes();
        }

        /// <summary>
        /// Displays All Recipes
        /// </summary>
        public void DisplayRecipes()
        {
            results_lbl.Text = "All Recipes";
            results_panel.Controls.Clear();

            RecipeBank bank = RecipeBank.GetInstance();

            foreach (Recipe recipe in bank.GetRecipes())
            {
                RecipeBox rp = new(recipe, false, this.parent);
                results_panel.Controls.Add(rp);
            }
        }

        /// <summary>
        /// Displays Results
        /// </summary>
        public void DisplayResults()
        {
            results_panel.Controls.Clear();

            RecipeBank bank = RecipeBank.GetInstance();

            List<Recipe> recipe_list = bank.SearchRecipeList(GetAll(search_keywords_panel, typeof(Label)));
            results_lbl.Text = "Results Found: " + recipe_list.Count();
            foreach (Recipe recipe in recipe_list)
            {
                RecipeBox rp = new RecipeBox(recipe, true, this.parent);
                results_panel.Controls.Add(rp);
            }
        }

        /// <summary>
        /// Add Recipe Button Clicked Event
        /// </summary>
        private void AddRecipeButtonOnClicked(object sender, EventArgs e)
        {
            addrecipe_form = new AddAndEditRecipeForm();
            addrecipe_form.ShowDialog(this);
            DisplayRecipes();
        }

        /// <summary>
        /// Close Button Clicked Event
        /// </summary>
        private void CloseButtonOnClicked(object sender, EventArgs e)
        {
            keywords--;
            if (keywords > 0)
                DisplayResults();
            else
                DisplayRecipes();
        }

        /// <summary>
        /// Search Button Clicked Event
        /// </summary>
        private void SearchButtonOnClicked(object sender, EventArgs e)
        {
            if (!(this.search_textbox.Text == ""))
            {
                KeywordBox keyword = new KeywordBox(search_textbox.Text);
                keyword.close.Click += new EventHandler(this.CloseButtonOnClicked);
                keywords++;

                search_keywords_panel.Controls.Add(keyword);
                search_textbox.Text = "";
                DisplayResults();
            }
        }

        /// <summary>
        /// Search Textbox OnKeyDown Event
        /// </summary>
        private void SearchTextboxOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        /// <summary>
        /// Gets All Controls with a specified Type inside a Control
        /// </summary>
        /// <param name="control">Control to be cast. </param>
        /// <param name="type">Type of the control to be search.</param>
        /// <returns>Returns an IEnumerable containing all controls with specified type inside a control.</returns>
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
