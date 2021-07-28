using System.Drawing;
using System.Windows.Forms;

namespace RatatouilleApp.CustomControls
{
    class ActionButton : Button
    {
        public ActionButton()
        {
            Size = new Size(320, 50);
            FlatStyle = FlatStyle.Popup;
            Padding = new Padding(0, 0, 0, 0);
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Sofia Pro Light", 12, FontStyle.Regular);
            BackColor = Color.FromArgb(255, 197, 102);
        }
    }
}
