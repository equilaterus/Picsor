using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picsor.Controls
{
    public partial class MultiButton : UserControl
    {
        private Button _Current;
        public MultiButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            if (_Current != null)
            {
                _Current.BackColor = Color.FromArgb(24, 24, 24);
                _Current.ForeColor = Color.Silver;
            }
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(86, 105, 53);
                btn.ForeColor = Color.FromArgb(136, 234, 17); 
                //btn.ForeColor = Color.FromArgb(224, 224, 224);
                _Current = btn;
            }
        }
    }
}
