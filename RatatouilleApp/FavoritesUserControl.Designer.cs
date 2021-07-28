
namespace RatatouilleApp
{
    partial class FavoritesUserControl
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
            this.favorites_lbl = new System.Windows.Forms.Label();
            this.favorites_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // favorites_lbl
            // 
            this.favorites_lbl.AutoSize = true;
            this.favorites_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favorites_lbl.Location = new System.Drawing.Point(54, 63);
            this.favorites_lbl.Margin = new System.Windows.Forms.Padding(41, 7, 0, 0);
            this.favorites_lbl.Name = "favorites_lbl";
            this.favorites_lbl.Size = new System.Drawing.Size(110, 32);
            this.favorites_lbl.TabIndex = 8;
            this.favorites_lbl.Text = "Favorites";
            // 
            // favorites_panel
            // 
            this.favorites_panel.AutoScroll = true;
            this.favorites_panel.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.favorites_panel.Location = new System.Drawing.Point(54, 122);
            this.favorites_panel.Margin = new System.Windows.Forms.Padding(0);
            this.favorites_panel.Name = "favorites_panel";
            this.favorites_panel.Size = new System.Drawing.Size(755, 515);
            this.favorites_panel.TabIndex = 12;
            // 
            // FavoritesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.favorites_panel);
            this.Controls.Add(this.favorites_lbl);
            this.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FavoritesUserControl";
            this.Size = new System.Drawing.Size(862, 753);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label favorites_lbl;
        private System.Windows.Forms.FlowLayoutPanel favorites_panel;
    }
}
