
namespace RatatouilleApp
{
    partial class RecipesUserControl
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
            this.search_btn = new System.Windows.Forms.Button();
            this.search_keywords_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.results_lbl = new System.Windows.Forms.Label();
            this.addrecipe_btn = new RatatouilleApp.CustomControls.ActionButton();
            this.searchbar_panel = new System.Windows.Forms.Panel();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.results_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchbar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(176)))), ((int)(((byte)(142)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Sofia Pro Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Image = global::RatatouilleApp.Properties.Resources.ic_search_24px;
            this.search_btn.Location = new System.Drawing.Point(759, 40);
            this.search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(50, 50);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "\r\n";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.SearchButtonOnClicked);
            // 
            // search_keywords_panel
            // 
            this.search_keywords_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_keywords_panel.AutoScroll = true;
            this.search_keywords_panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.search_keywords_panel.Location = new System.Drawing.Point(54, 111);
            this.search_keywords_panel.Margin = new System.Windows.Forms.Padding(0);
            this.search_keywords_panel.Name = "search_keywords_panel";
            this.search_keywords_panel.Size = new System.Drawing.Size(755, 45);
            this.search_keywords_panel.TabIndex = 5;
            // 
            // results_lbl
            // 
            this.results_lbl.AutoSize = true;
            this.results_lbl.Font = new System.Drawing.Font("Sofia Pro Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.results_lbl.Location = new System.Drawing.Point(54, 161);
            this.results_lbl.Margin = new System.Windows.Forms.Padding(30, 5, 0, 0);
            this.results_lbl.Name = "results_lbl";
            this.results_lbl.Size = new System.Drawing.Size(127, 32);
            this.results_lbl.TabIndex = 7;
            this.results_lbl.Text = "All Recipes";
            // 
            // addrecipe_btn
            // 
            this.addrecipe_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(176)))), ((int)(((byte)(142)))));
            this.addrecipe_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addrecipe_btn.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addrecipe_btn.Location = new System.Drawing.Point(649, 676);
            this.addrecipe_btn.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.addrecipe_btn.Name = "addrecipe_btn";
            this.addrecipe_btn.Size = new System.Drawing.Size(160, 50);
            this.addrecipe_btn.TabIndex = 8;
            this.addrecipe_btn.Text = "add recipe";
            this.addrecipe_btn.UseVisualStyleBackColor = false;
            this.addrecipe_btn.Click += new System.EventHandler(this.AddRecipeButtonOnClicked);
            // 
            // searchbar_panel
            // 
            this.searchbar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchbar_panel.Controls.Add(this.search_textbox);
            this.searchbar_panel.Location = new System.Drawing.Point(479, 40);
            this.searchbar_panel.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.searchbar_panel.Name = "searchbar_panel";
            this.searchbar_panel.Padding = new System.Windows.Forms.Padding(5);
            this.searchbar_panel.Size = new System.Drawing.Size(275, 50);
            this.searchbar_panel.TabIndex = 0;
            // 
            // search_textbox
            // 
            this.search_textbox.BackColor = System.Drawing.Color.White;
            this.search_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_textbox.Location = new System.Drawing.Point(12, 10);
            this.search_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.PlaceholderText = "enter keyword";
            this.search_textbox.Size = new System.Drawing.Size(251, 27);
            this.search_textbox.TabIndex = 0;
            this.search_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextboxOnKeyDown);
            // 
            // results_panel
            // 
            this.results_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.results_panel.AutoScroll = true;
            this.results_panel.Location = new System.Drawing.Point(54, 213);
            this.results_panel.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.results_panel.Name = "results_panel";
            this.results_panel.Size = new System.Drawing.Size(755, 429);
            this.results_panel.TabIndex = 6;
            // 
            // RecipesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchbar_panel);
            this.Controls.Add(this.addrecipe_btn);
            this.Controls.Add(this.results_lbl);
            this.Controls.Add(this.results_panel);
            this.Controls.Add(this.search_keywords_panel);
            this.Controls.Add(this.search_btn);
            this.Font = new System.Drawing.Font("Sofia Pro Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecipesUserControl";
            this.Size = new System.Drawing.Size(862, 753);
            this.searchbar_panel.ResumeLayout(false);
            this.searchbar_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.FlowLayoutPanel search_keywords_panel;
        private System.Windows.Forms.Label results_lbl;
        private CustomControls.ActionButton addrecipe_btn;
        private System.Windows.Forms.Panel searchbar_panel;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.FlowLayoutPanel results_panel;
    }
}
