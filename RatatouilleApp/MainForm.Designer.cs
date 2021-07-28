
namespace RatatouilleApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.home_menubtn = new RatatouilleApp.CustomControls.MenuButton();
            this.recipes_menubtn = new RatatouilleApp.CustomControls.MenuButton();
            this.control_panel = new System.Windows.Forms.Panel();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.logo_picturebox = new System.Windows.Forms.PictureBox();
            this.favorites_menubtn = new RatatouilleApp.CustomControls.MenuButton();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // home_menubtn
            // 
            this.home_menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.home_menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_menubtn.FlatAppearance.BorderSize = 0;
            this.home_menubtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.home_menubtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.home_menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_menubtn.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_menubtn.ForeColor = System.Drawing.Color.White;
            this.home_menubtn.Location = new System.Drawing.Point(0, 275);
            this.home_menubtn.Margin = new System.Windows.Forms.Padding(0);
            this.home_menubtn.Name = "home_menubtn";
            this.home_menubtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.home_menubtn.Size = new System.Drawing.Size(320, 60);
            this.home_menubtn.TabIndex = 1;
            this.home_menubtn.Text = "Home";
            this.home_menubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_menubtn.UseVisualStyleBackColor = false;
            this.home_menubtn.Click += new System.EventHandler(this.HomeMenuButtonOnClicked);
            // 
            // recipes_menubtn
            // 
            this.recipes_menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(176)))), ((int)(((byte)(142)))));
            this.recipes_menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recipes_menubtn.FlatAppearance.BorderSize = 0;
            this.recipes_menubtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.recipes_menubtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.recipes_menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recipes_menubtn.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipes_menubtn.ForeColor = System.Drawing.Color.Black;
            this.recipes_menubtn.Location = new System.Drawing.Point(0, 335);
            this.recipes_menubtn.Margin = new System.Windows.Forms.Padding(0);
            this.recipes_menubtn.Name = "recipes_menubtn";
            this.recipes_menubtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.recipes_menubtn.Size = new System.Drawing.Size(320, 60);
            this.recipes_menubtn.TabIndex = 2;
            this.recipes_menubtn.Text = "Recipes";
            this.recipes_menubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recipes_menubtn.UseVisualStyleBackColor = false;
            this.recipes_menubtn.Click += new System.EventHandler(this.RecipesMenuButtonOnClicked);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.White;
            this.control_panel.Location = new System.Drawing.Point(320, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(862, 753);
            this.control_panel.TabIndex = 4;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(176)))), ((int)(((byte)(142)))));
            this.sidebar_panel.Controls.Add(this.logo_picturebox);
            this.sidebar_panel.Controls.Add(this.favorites_menubtn);
            this.sidebar_panel.Controls.Add(this.recipes_menubtn);
            this.sidebar_panel.Controls.Add(this.home_menubtn);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(320, 753);
            this.sidebar_panel.TabIndex = 4;
            // 
            // logo_picturebox
            // 
            this.logo_picturebox.Image = global::RatatouilleApp.Properties.Resources.logo;
            this.logo_picturebox.Location = new System.Drawing.Point(0, 0);
            this.logo_picturebox.Margin = new System.Windows.Forms.Padding(0);
            this.logo_picturebox.Name = "logo_picturebox";
            this.logo_picturebox.Size = new System.Drawing.Size(320, 215);
            this.logo_picturebox.TabIndex = 4;
            this.logo_picturebox.TabStop = false;
            // 
            // favorites_menubtn
            // 
            this.favorites_menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(176)))), ((int)(((byte)(142)))));
            this.favorites_menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favorites_menubtn.FlatAppearance.BorderSize = 0;
            this.favorites_menubtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.favorites_menubtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.favorites_menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favorites_menubtn.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favorites_menubtn.ForeColor = System.Drawing.Color.Black;
            this.favorites_menubtn.Location = new System.Drawing.Point(0, 395);
            this.favorites_menubtn.Margin = new System.Windows.Forms.Padding(0);
            this.favorites_menubtn.Name = "favorites_menubtn";
            this.favorites_menubtn.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.favorites_menubtn.Size = new System.Drawing.Size(320, 60);
            this.favorites_menubtn.TabIndex = 3;
            this.favorites_menubtn.Text = "Favorites";
            this.favorites_menubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favorites_menubtn.UseVisualStyleBackColor = false;
            this.favorites_menubtn.Click += new System.EventHandler(this.FavoritesMenuButtonOnClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.sidebar_panel);
            this.Controls.Add(this.control_panel);
            this.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ratatouille App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormOnClosing);
            this.sidebar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.MenuButton home_menubtn;
        private CustomControls.MenuButton recipes_menubtn;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Panel sidebar_panel;
        private CustomControls.MenuButton favorites_menubtn;
        private System.Windows.Forms.PictureBox logo_picturebox;
    }
}

