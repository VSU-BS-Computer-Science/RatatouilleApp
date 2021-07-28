using System;
using System.Drawing;
using System.Windows.Forms;

namespace RatatouilleApp.CustomControls
{

    class KeywordBox : FlowLayoutPanel
    {
        private readonly Label lbl;
        public PictureBox close;

        public KeywordBox(string keyword)
        {
            this.lbl = new Label
            {
                Text = keyword,
                Margin = new Padding(3),
                BackColor = Color.Transparent,
                AutoSize = true,
            };

            this.close = new PictureBox
            {
                Image = Properties.Resources.ic_close_24px,
                Margin = new Padding(0, 3, 3, 3),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.AutoSize,
            };

            this.Font = new Font("Sofia Pro Light", 10, FontStyle.Regular);
            this.Margin = new Padding(3);
            this.AutoSize = true;
            this.BackColor = Color.FromArgb(233, 176, 142);
            this.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(this.lbl);
            this.Controls.Add(this.close);

            this.close.Click += new System.EventHandler(this.CloseButtonOnClicked);
        }

        private void CloseButtonOnClicked(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
