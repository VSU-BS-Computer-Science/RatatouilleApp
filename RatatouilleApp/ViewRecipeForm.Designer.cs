
namespace RatatouilleApp
{
    partial class ViewRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecipeForm));
            this.viewrecipeform_panel = new System.Windows.Forms.Panel();
            this.delete_btn = new RatatouilleApp.CustomControls.ActionButton();
            this.edit_btn = new RatatouilleApp.CustomControls.ActionButton();
            this.heart_btn = new System.Windows.Forms.PictureBox();
            this.recipe_name = new System.Windows.Forms.Label();
            this.recipe_procedure = new System.Windows.Forms.RichTextBox();
            this.recipe_ingredients = new System.Windows.Forms.RichTextBox();
            this.procedure_lbl = new System.Windows.Forms.Label();
            this.ingredients_lbl = new System.Windows.Forms.Label();
            this.recipe_servings = new System.Windows.Forms.Label();
            this.recipe_time = new System.Windows.Forms.Label();
            this.recipe_picturebox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.viewrecipeform_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // viewrecipeform_panel
            // 
            this.viewrecipeform_panel.BackColor = System.Drawing.Color.White;
            this.viewrecipeform_panel.Controls.Add(this.delete_btn);
            this.viewrecipeform_panel.Controls.Add(this.edit_btn);
            this.viewrecipeform_panel.Controls.Add(this.heart_btn);
            this.viewrecipeform_panel.Controls.Add(this.recipe_name);
            this.viewrecipeform_panel.Controls.Add(this.recipe_procedure);
            this.viewrecipeform_panel.Controls.Add(this.recipe_ingredients);
            this.viewrecipeform_panel.Controls.Add(this.procedure_lbl);
            this.viewrecipeform_panel.Controls.Add(this.ingredients_lbl);
            this.viewrecipeform_panel.Controls.Add(this.recipe_servings);
            this.viewrecipeform_panel.Controls.Add(this.recipe_time);
            this.viewrecipeform_panel.Controls.Add(this.recipe_picturebox);
            this.viewrecipeform_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewrecipeform_panel.Location = new System.Drawing.Point(0, 0);
            this.viewrecipeform_panel.Margin = new System.Windows.Forms.Padding(0);
            this.viewrecipeform_panel.Name = "viewrecipeform_panel";
            this.viewrecipeform_panel.Size = new System.Drawing.Size(1182, 753);
            this.viewrecipeform_panel.TabIndex = 2;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(110)))), ((int)(((byte)(58)))));
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.Location = new System.Drawing.Point(1020, 657);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 50);
            this.delete_btn.TabIndex = 24;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.DeleteButtonOnClicked);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(158)))), ((int)(((byte)(79)))));
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_btn.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit_btn.Location = new System.Drawing.Point(880, 657);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(10);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(120, 50);
            this.edit_btn.TabIndex = 23;
            this.edit_btn.Text = "edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.EditButtonOnClicked);
            // 
            // heart_btn
            // 
            this.heart_btn.BackColor = System.Drawing.Color.Transparent;
            this.heart_btn.Image = global::RatatouilleApp.Properties.Resources.heart_2_2;
            this.heart_btn.Location = new System.Drawing.Point(1110, 60);
            this.heart_btn.Name = "heart_btn";
            this.heart_btn.Size = new System.Drawing.Size(30, 30);
            this.heart_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart_btn.TabIndex = 13;
            this.heart_btn.TabStop = false;
            // 
            // recipe_name
            // 
            this.recipe_name.BackColor = System.Drawing.Color.Transparent;
            this.recipe_name.Font = new System.Drawing.Font("Simply Sweet Script ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipe_name.Location = new System.Drawing.Point(500, 37);
            this.recipe_name.Margin = new System.Windows.Forms.Padding(120, 0, 120, 0);
            this.recipe_name.Name = "recipe_name";
            this.recipe_name.Size = new System.Drawing.Size(422, 80);
            this.recipe_name.TabIndex = 2;
            this.recipe_name.Text = "Adobong Liempo Recipe";
            this.recipe_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recipe_procedure
            // 
            this.recipe_procedure.BackColor = System.Drawing.Color.White;
            this.recipe_procedure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipe_procedure.DetectUrls = false;
            this.recipe_procedure.Font = new System.Drawing.Font("Sofia Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipe_procedure.Location = new System.Drawing.Point(861, 254);
            this.recipe_procedure.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.recipe_procedure.Name = "recipe_procedure";
            this.recipe_procedure.ReadOnly = true;
            this.recipe_procedure.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.recipe_procedure.Size = new System.Drawing.Size(285, 364);
            this.recipe_procedure.TabIndex = 10;
            this.recipe_procedure.Text = resources.GetString("recipe_procedure.Text");
            // 
            // recipe_ingredients
            // 
            this.recipe_ingredients.BackColor = System.Drawing.Color.White;
            this.recipe_ingredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recipe_ingredients.DetectUrls = false;
            this.recipe_ingredients.Font = new System.Drawing.Font("Sofia Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipe_ingredients.Location = new System.Drawing.Point(506, 254);
            this.recipe_ingredients.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.recipe_ingredients.Name = "recipe_ingredients";
            this.recipe_ingredients.ReadOnly = true;
            this.recipe_ingredients.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.recipe_ingredients.Size = new System.Drawing.Size(285, 364);
            this.recipe_ingredients.TabIndex = 9;
            this.recipe_ingredients.Text = resources.GetString("recipe_ingredients.Text");
            // 
            // procedure_lbl
            // 
            this.procedure_lbl.AutoSize = true;
            this.procedure_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.procedure_lbl.Location = new System.Drawing.Point(855, 217);
            this.procedure_lbl.Name = "procedure_lbl";
            this.procedure_lbl.Size = new System.Drawing.Size(192, 27);
            this.procedure_lbl.TabIndex = 8;
            this.procedure_lbl.Text = "Cooking Procedure:";
            // 
            // ingredients_lbl
            // 
            this.ingredients_lbl.AutoSize = true;
            this.ingredients_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredients_lbl.Location = new System.Drawing.Point(500, 217);
            this.ingredients_lbl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ingredients_lbl.Name = "ingredients_lbl";
            this.ingredients_lbl.Size = new System.Drawing.Size(117, 27);
            this.ingredients_lbl.TabIndex = 7;
            this.ingredients_lbl.Text = "Ingredients:";
            // 
            // recipe_servings
            // 
            this.recipe_servings.AutoSize = true;
            this.recipe_servings.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipe_servings.Location = new System.Drawing.Point(500, 180);
            this.recipe_servings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.recipe_servings.Name = "recipe_servings";
            this.recipe_servings.Size = new System.Drawing.Size(115, 27);
            this.recipe_servings.TabIndex = 4;
            this.recipe_servings.Text = "Servings: 12";
            // 
            // recipe_time
            // 
            this.recipe_time.AutoSize = true;
            this.recipe_time.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipe_time.Location = new System.Drawing.Point(500, 143);
            this.recipe_time.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.recipe_time.Name = "recipe_time";
            this.recipe_time.Size = new System.Drawing.Size(221, 27);
            this.recipe_time.TabIndex = 3;
            this.recipe_time.Text = "Cooking Time: 50 mins.";
            // 
            // recipe_picturebox
            // 
            this.recipe_picturebox.Dock = System.Windows.Forms.DockStyle.Left;
            this.recipe_picturebox.Location = new System.Drawing.Point(0, 0);
            this.recipe_picturebox.Name = "recipe_picturebox";
            this.recipe_picturebox.Size = new System.Drawing.Size(470, 753);
            this.recipe_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipe_picturebox.TabIndex = 0;
            this.recipe_picturebox.TabStop = false;
            // 
            // ViewRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.viewrecipeform_panel);
            this.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Recipe Form";
            this.viewrecipeform_panel.ResumeLayout(false);
            this.viewrecipeform_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipe_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewrecipeform_panel;
        private System.Windows.Forms.Label ingredients_lbl;
        private System.Windows.Forms.Label procedure_lbl;
        public System.Windows.Forms.PictureBox recipe_picturebox;
        public System.Windows.Forms.Label recipe_name;
        public System.Windows.Forms.Label recipe_time;
        public System.Windows.Forms.Label recipe_servings;
        public System.Windows.Forms.RichTextBox recipe_ingredients;
        public System.Windows.Forms.RichTextBox recipe_procedure;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.PictureBox heart_btn;
        private CustomControls.ActionButton edit_btn;
        private CustomControls.ActionButton delete_btn;
    }
}