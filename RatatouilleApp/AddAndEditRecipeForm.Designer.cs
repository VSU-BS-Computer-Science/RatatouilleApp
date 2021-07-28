
namespace RatatouilleApp
{
    partial class AddAndEditRecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditRecipeForm));
            this.recipe_picturebox = new System.Windows.Forms.PictureBox();
            this.camera_icon = new System.Windows.Forms.PictureBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.choose_image_link = new System.Windows.Forms.LinkLabel();
            this.cookingtime_lbl = new System.Windows.Forms.Label();
            this.time_combobox = new System.Windows.Forms.ComboBox();
            this.servings_lbl = new System.Windows.Forms.Label();
            this.ingredients_lbl = new System.Windows.Forms.Label();
            this.procedure_lbl = new System.Windows.Forms.Label();
            this.ingredients_textbox = new System.Windows.Forms.TextBox();
            this.procedure_textbox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new RatatouilleApp.CustomControls.ActionButton();
            this.time_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.servings_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.img_location_lbl = new System.Windows.Forms.Label();
            this.recipeform_panel = new System.Windows.Forms.Panel();
            this.action_buttons_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.add_btn = new RatatouilleApp.CustomControls.ActionButton();
            this.save_btn = new RatatouilleApp.CustomControls.ActionButton();
            this.help_lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.recipe_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servings_numeric_updown)).BeginInit();
            this.recipeform_panel.SuspendLayout();
            this.action_buttons_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipe_picturebox
            // 
            this.recipe_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.recipe_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recipe_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipe_picturebox.Dock = System.Windows.Forms.DockStyle.Left;
            this.recipe_picturebox.Location = new System.Drawing.Point(0, 0);
            this.recipe_picturebox.Margin = new System.Windows.Forms.Padding(0);
            this.recipe_picturebox.Name = "recipe_picturebox";
            this.recipe_picturebox.Size = new System.Drawing.Size(470, 753);
            this.recipe_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recipe_picturebox.TabIndex = 0;
            this.recipe_picturebox.TabStop = false;
            // 
            // camera_icon
            // 
            this.camera_icon.BackColor = System.Drawing.Color.Transparent;
            this.camera_icon.Image = global::RatatouilleApp.Properties.Resources.camera_20;
            this.camera_icon.Location = new System.Drawing.Point(40, 33);
            this.camera_icon.Margin = new System.Windows.Forms.Padding(0);
            this.camera_icon.Name = "camera_icon";
            this.camera_icon.Size = new System.Drawing.Size(19, 19);
            this.camera_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camera_icon.TabIndex = 1;
            this.camera_icon.TabStop = false;
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Simply Sweet Script ", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textbox.Location = new System.Drawing.Point(500, 37);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(120, 3, 120, 3);
            this.name_textbox.MaxLength = 200;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.PlaceholderText = "New Recipe Name*";
            this.name_textbox.Size = new System.Drawing.Size(500, 80);
            this.name_textbox.TabIndex = 3;
            // 
            // choose_image_link
            // 
            this.choose_image_link.AutoSize = true;
            this.choose_image_link.BackColor = System.Drawing.Color.Transparent;
            this.choose_image_link.Font = new System.Drawing.Font("Sofia Pro Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choose_image_link.LinkColor = System.Drawing.Color.Black;
            this.choose_image_link.Location = new System.Drawing.Point(59, 33);
            this.choose_image_link.Margin = new System.Windows.Forms.Padding(0);
            this.choose_image_link.Name = "choose_image_link";
            this.choose_image_link.Size = new System.Drawing.Size(115, 19);
            this.choose_image_link.TabIndex = 5;
            this.choose_image_link.TabStop = true;
            this.choose_image_link.Text = "Choose Image...";
            this.choose_image_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChooseImageLinkOnClicked);
            // 
            // cookingtime_lbl
            // 
            this.cookingtime_lbl.AutoSize = true;
            this.cookingtime_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cookingtime_lbl.Location = new System.Drawing.Point(500, 143);
            this.cookingtime_lbl.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.cookingtime_lbl.Name = "cookingtime_lbl";
            this.cookingtime_lbl.Size = new System.Drawing.Size(151, 27);
            this.cookingtime_lbl.TabIndex = 6;
            this.cookingtime_lbl.Text = "Cooking Time:*";
            // 
            // time_combobox
            // 
            this.time_combobox.BackColor = System.Drawing.Color.White;
            this.time_combobox.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_combobox.FormattingEnabled = true;
            this.time_combobox.Items.AddRange(new object[] {
            "hrs.",
            "mins."});
            this.time_combobox.Location = new System.Drawing.Point(776, 143);
            this.time_combobox.Name = "time_combobox";
            this.time_combobox.Size = new System.Drawing.Size(70, 35);
            this.time_combobox.TabIndex = 10;
            this.time_combobox.Text = "hrs.";
            // 
            // servings_lbl
            // 
            this.servings_lbl.AutoSize = true;
            this.servings_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servings_lbl.Location = new System.Drawing.Point(502, 205);
            this.servings_lbl.Margin = new System.Windows.Forms.Padding(10, 35, 3, 0);
            this.servings_lbl.Name = "servings_lbl";
            this.servings_lbl.Size = new System.Drawing.Size(103, 27);
            this.servings_lbl.TabIndex = 11;
            this.servings_lbl.Text = "Servings:*";
            // 
            // ingredients_lbl
            // 
            this.ingredients_lbl.AutoSize = true;
            this.ingredients_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredients_lbl.Location = new System.Drawing.Point(500, 267);
            this.ingredients_lbl.Margin = new System.Windows.Forms.Padding(10, 35, 3, 0);
            this.ingredients_lbl.Name = "ingredients_lbl";
            this.ingredients_lbl.Size = new System.Drawing.Size(127, 27);
            this.ingredients_lbl.TabIndex = 15;
            this.ingredients_lbl.Text = "Ingredients:*";
            // 
            // procedure_lbl
            // 
            this.procedure_lbl.AutoSize = true;
            this.procedure_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.procedure_lbl.Location = new System.Drawing.Point(855, 267);
            this.procedure_lbl.Margin = new System.Windows.Forms.Padding(10, 50, 3, 0);
            this.procedure_lbl.Name = "procedure_lbl";
            this.procedure_lbl.Size = new System.Drawing.Size(202, 27);
            this.procedure_lbl.TabIndex = 16;
            this.procedure_lbl.Text = "Cooking Procedure:*";
            // 
            // ingredients_textbox
            // 
            this.ingredients_textbox.Font = new System.Drawing.Font("Sofia Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingredients_textbox.Location = new System.Drawing.Point(502, 314);
            this.ingredients_textbox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.ingredients_textbox.Multiline = true;
            this.ingredients_textbox.Name = "ingredients_textbox";
            this.ingredients_textbox.PlaceholderText = "enter ingredients here...";
            this.ingredients_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredients_textbox.Size = new System.Drawing.Size(285, 315);
            this.ingredients_textbox.TabIndex = 18;
            // 
            // procedure_textbox
            // 
            this.procedure_textbox.Font = new System.Drawing.Font("Sofia Pro Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.procedure_textbox.Location = new System.Drawing.Point(855, 314);
            this.procedure_textbox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.procedure_textbox.Multiline = true;
            this.procedure_textbox.Name = "procedure_textbox";
            this.procedure_textbox.PlaceholderText = "enter cooking procedure here...";
            this.procedure_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.procedure_textbox.Size = new System.Drawing.Size(285, 315);
            this.procedure_textbox.TabIndex = 19;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Gray;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_btn.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_btn.Location = new System.Drawing.Point(306, 10);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(120, 50);
            this.cancel_btn.TabIndex = 20;
            this.cancel_btn.Text = "cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            // 
            // time_numeric_updown
            // 
            this.time_numeric_updown.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_numeric_updown.Location = new System.Drawing.Point(682, 143);
            this.time_numeric_updown.Name = "time_numeric_updown";
            this.time_numeric_updown.Size = new System.Drawing.Size(70, 34);
            this.time_numeric_updown.TabIndex = 22;
            // 
            // servings_numeric_updown
            // 
            this.servings_numeric_updown.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.servings_numeric_updown.Location = new System.Drawing.Point(682, 198);
            this.servings_numeric_updown.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.servings_numeric_updown.Name = "servings_numeric_updown";
            this.servings_numeric_updown.Size = new System.Drawing.Size(70, 34);
            this.servings_numeric_updown.TabIndex = 23;
            // 
            // img_location_lbl
            // 
            this.img_location_lbl.AutoSize = true;
            this.img_location_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.img_location_lbl.Location = new System.Drawing.Point(0, 0);
            this.img_location_lbl.Name = "img_location_lbl";
            this.img_location_lbl.Size = new System.Drawing.Size(89, 16);
            this.img_location_lbl.TabIndex = 24;
            this.img_location_lbl.Text = "ImageLocation";
            // 
            // recipeform_panel
            // 
            this.recipeform_panel.Controls.Add(this.action_buttons_panel);
            this.recipeform_panel.Controls.Add(this.help_lbl);
            this.recipeform_panel.Controls.Add(this.procedure_textbox);
            this.recipeform_panel.Controls.Add(this.servings_numeric_updown);
            this.recipeform_panel.Controls.Add(this.servings_lbl);
            this.recipeform_panel.Controls.Add(this.time_combobox);
            this.recipeform_panel.Controls.Add(this.time_numeric_updown);
            this.recipeform_panel.Controls.Add(this.cookingtime_lbl);
            this.recipeform_panel.Controls.Add(this.name_textbox);
            this.recipeform_panel.Controls.Add(this.img_location_lbl);
            this.recipeform_panel.Controls.Add(this.procedure_lbl);
            this.recipeform_panel.Controls.Add(this.ingredients_lbl);
            this.recipeform_panel.Controls.Add(this.camera_icon);
            this.recipeform_panel.Controls.Add(this.choose_image_link);
            this.recipeform_panel.Controls.Add(this.ingredients_textbox);
            this.recipeform_panel.Controls.Add(this.recipe_picturebox);
            this.recipeform_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeform_panel.Location = new System.Drawing.Point(0, 0);
            this.recipeform_panel.Name = "recipeform_panel";
            this.recipeform_panel.Size = new System.Drawing.Size(1182, 753);
            this.recipeform_panel.TabIndex = 25;
            // 
            // action_buttons_panel
            // 
            this.action_buttons_panel.Controls.Add(this.cancel_btn);
            this.action_buttons_panel.Controls.Add(this.add_btn);
            this.action_buttons_panel.Controls.Add(this.save_btn);
            this.action_buttons_panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.action_buttons_panel.Location = new System.Drawing.Point(714, 666);
            this.action_buttons_panel.Name = "action_buttons_panel";
            this.action_buttons_panel.Size = new System.Drawing.Size(426, 75);
            this.action_buttons_panel.TabIndex = 28;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(110)))), ((int)(((byte)(58)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_btn.Location = new System.Drawing.Point(166, 10);
            this.add_btn.Margin = new System.Windows.Forms.Padding(10);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 50);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.AddButtonOnClicked);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(158)))), ((int)(((byte)(79)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_btn.Location = new System.Drawing.Point(26, 10);
            this.save_btn.Margin = new System.Windows.Forms.Padding(10);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(120, 50);
            this.save_btn.TabIndex = 23;
            this.save_btn.Text = "save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.SaveButtonOnClicked);
            // 
            // help_lbl
            // 
            this.help_lbl.AutoSize = true;
            this.help_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.help_lbl.Location = new System.Drawing.Point(1076, 33);
            this.help_lbl.Name = "help_lbl";
            this.help_lbl.Size = new System.Drawing.Size(64, 27);
            this.help_lbl.TabIndex = 27;
            this.help_lbl.Text = "Help?";
            this.toolTip1.SetToolTip(this.help_lbl, "Required Fields:\r\n    Recipe Name - should be unique\r\n\r\nNot Required Fileds:\r\n   " +
        " Recipe Image\r\n    Cooking Time\r\n    Servings\r\n    Ingredients\r\n    Cooking Proc" +
        "edure\r\n");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // AddAndEditRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancel_btn;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.recipeform_panel);
            this.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddAndEditRecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Form";
            ((System.ComponentModel.ISupportInitialize)(this.recipe_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servings_numeric_updown)).EndInit();
            this.recipeform_panel.ResumeLayout(false);
            this.recipeform_panel.PerformLayout();
            this.action_buttons_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox recipe_picturebox;
        private System.Windows.Forms.PictureBox camera_icon;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.LinkLabel choose_image_link;
        private System.Windows.Forms.Label cookingtime_lbl;
        private System.Windows.Forms.ComboBox time_combobox;
        private System.Windows.Forms.Label servings_lbl;
        private System.Windows.Forms.Label ingredients_lbl;
        private System.Windows.Forms.Label procedure_lbl;
        private System.Windows.Forms.TextBox ingredients_textbox;
        private System.Windows.Forms.TextBox procedure_textbox;
        private CustomControls.ActionButton cancel_btn;
        private System.Windows.Forms.NumericUpDown time_numeric_updown;
        private System.Windows.Forms.NumericUpDown servings_numeric_updown;
        private System.Windows.Forms.Label img_location_lbl;
        private System.Windows.Forms.Panel recipeform_panel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label help_lbl;
        private System.Windows.Forms.FlowLayoutPanel action_buttons_panel;
        private CustomControls.ActionButton add_btn;
        private CustomControls.ActionButton save_btn;
    }
}