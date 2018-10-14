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

        public event EventHandler ButtonChanged;

        protected void SetDefault(object defaultButton)
        {
            HandleMultiButton_Click(defaultButton, null);
        }

        protected void HandleMultiButton_Click(object sender, EventArgs e)
        {
            if (Current != null)
            {
                Current.BackColor = Color.FromArgb(20, 20, 20);
                Current.ForeColor = Color.Silver;
            }
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(86, 105, 53);
                btn.ForeColor = Color.FromArgb(136, 234, 17);
                Current = btn;

                // Trigger event
                ButtonChanged?.Invoke(sender, e);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MultiButton
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "MultiButton";
            this.ResumeLayout(false);
        }
    }
}
