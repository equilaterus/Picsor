using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picsor.Controls
{
    public class MultiButton : UserControl
    {
        public Button Current { get; private set; }

        protected void SetDefault(object defaultButton)
        {
            HandleMultiButton_Click(defaultButton, null);
        }

        protected void HandleMultiButton_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                Current.BackColor = Color.FromArgb(24, 24, 24);
                Current.ForeColor = Color.Silver;
            }
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(86, 105, 53);
                btn.ForeColor = Color.FromArgb(136, 234, 17);
                //btn.ForeColor = Color.FromArgb(224, 224, 224);
                Current = btn;
            }
        }
    }
}
