
namespace RatatouilleApp
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recently_viewedlbl = new System.Windows.Forms.Label();
            this.suggested_recipe_img = new System.Windows.Forms.PictureBox();
            this.recently_viewed_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.shape_picturebox = new System.Windows.Forms.PictureBox();
            this.suggested_recipelbl = new System.Windows.Forms.Label();
            this.suggested_recipe_name = new System.Windows.Forms.Label();
            this.indicator_picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.suggested_recipe_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // recently_viewedlbl
            // 
            this.recently_viewedlbl.AutoSize = true;
            this.recently_viewedlbl.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recently_viewedlbl.Location = new System.Drawing.Point(44, 498);
            this.recently_viewedlbl.Margin = new System.Windows.Forms.Padding(30, 40, 0, 10);
            this.recently_viewedlbl.Name = "recently_viewedlbl";
            this.recently_viewedlbl.Size = new System.Drawing.Size(185, 32);
            this.recently_viewedlbl.TabIndex = 0;
            this.recently_viewedlbl.Text = "Recently Viewed";
            // 
            // suggested_recipe_img
            // 
            this.suggested_recipe_img.BackColor = System.Drawing.Color.White;
            this.suggested_recipe_img.Location = new System.Drawing.Point(0, 0);
            this.suggested_recipe_img.Margin = new System.Windows.Forms.Padding(0);
            this.suggested_recipe_img.Name = "suggested_recipe_img";
            this.suggested_recipe_img.Size = new System.Drawing.Size(862, 458);
            this.suggested_recipe_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.suggested_recipe_img.TabIndex = 4;
            this.suggested_recipe_img.TabStop = false;
            // 
            // recently_viewed_panel
            // 
            this.recently_viewed_panel.AutoScroll = true;
            this.recently_viewed_panel.Location = new System.Drawing.Point(44, 540);
            this.recently_viewed_panel.Margin = new System.Windows.Forms.Padding(0);
            this.recently_viewed_panel.Name = "recently_viewed_panel";
            this.recently_viewed_panel.Size = new System.Drawing.Size(755, 165);
            this.recently_viewed_panel.TabIndex = 11;
            // 
            // shape_picturebox
            // 
            this.shape_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.shape_picturebox.Image = global::RatatouilleApp.Properties.Resources.custom_shape;
            this.shape_picturebox.Location = new System.Drawing.Point(0, 177);
            this.shape_picturebox.Margin = new System.Windows.Forms.Padding(0);
            this.shape_picturebox.Name = "shape_picturebox";
            this.shape_picturebox.Size = new System.Drawing.Size(862, 281);
            this.shape_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shape_picturebox.TabIndex = 14;
            this.shape_picturebox.TabStop = false;
            // 
            // suggested_recipelbl
            // 
            this.suggested_recipelbl.AutoSize = true;
            this.suggested_recipelbl.BackColor = System.Drawing.Color.Transparent;
            this.suggested_recipelbl.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suggested_recipelbl.Location = new System.Drawing.Point(44, 86);
            this.suggested_recipelbl.Margin = new System.Windows.Forms.Padding(30, 40, 0, 10);
            this.suggested_recipelbl.Name = "suggested_recipelbl";
            this.suggested_recipelbl.Size = new System.Drawing.Size(207, 32);
            this.suggested_recipelbl.TabIndex = 15;
            this.suggested_recipelbl.Text = "Suggested Recipe";
            // 
            // suggested_recipe_name
            // 
            this.suggested_recipe_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.suggested_recipe_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(176)))), ((int)(((byte)(142)))));
            this.suggested_recipe_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suggested_recipe_name.Font = new System.Drawing.Font("Sofia Pro Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suggested_recipe_name.Location = new System.Drawing.Point(96, 407);
            this.suggested_recipe_name.Margin = new System.Windows.Forms.Padding(30, 40, 0, 10);
            this.suggested_recipe_name.Name = "suggested_recipe_name";
            this.suggested_recipe_name.Size = new System.Drawing.Size(703, 35);
            this.suggested_recipe_name.TabIndex = 16;
            this.suggested_recipe_name.Text = "Chicken Adobo Recipe";
            this.suggested_recipe_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // indicator_picturebox
            // 
            this.indicator_picturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(51)))), ((int)(((byte)(13)))));
            this.indicator_picturebox.Location = new System.Drawing.Point(802, 407);
            this.indicator_picturebox.Name = "indicator_picturebox";
            this.indicator_picturebox.Size = new System.Drawing.Size(10, 35);
            this.indicator_picturebox.TabIndex = 17;
            this.indicator_picturebox.TabStop = false;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.indicator_picturebox);
            this.Controls.Add(this.suggested_recipe_name);
            this.Controls.Add(this.suggested_recipelbl);
            this.Controls.Add(this.shape_picturebox);
            this.Controls.Add(this.suggested_recipe_img);
            this.Controls.Add(this.recently_viewed_panel);
            this.Controls.Add(this.recently_viewedlbl);
            this.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(862, 753);
            ((System.ComponentModel.ISupportInitialize)(this.suggested_recipe_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recently_viewedlbl;
        private System.Windows.Forms.PictureBox suggested_recipe_img;
        private System.Windows.Forms.FlowLayoutPanel recently_viewed_panel;
        private System.Windows.Forms.PictureBox shape_picturebox;
        private System.Windows.Forms.Label suggested_recipelbl;
        private System.Windows.Forms.Label suggested_recipe_name;
        private System.Windows.Forms.PictureBox indicator_picturebox;
    }
}
