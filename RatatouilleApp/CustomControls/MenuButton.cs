using System.Drawing;
using System.Windows.Forms;

namespace RatatouilleApp.CustomControls
{
    class MenuButton : Button
    {
        public MenuButton()
        {
            Size = new Size(320, 60);
            FlatStyle = FlatStyle.Flat;
            Padding = new Padding(90, 0, 0, 0);
            TextAlign = ContentAlignment.MiddleLeft;
            Font = new Font("Sofia Pro Light", 14, FontStyle.Regular);
            BackColor = Color.FromArgb(255, 197, 102);
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }
    }
}
