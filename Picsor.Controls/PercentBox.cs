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
    public partial class PercentBox : UserControl, IFontCustomizable
    {
        public int Value
        {
            get
            {
                int value = 0;
                if (!int.TryParse(tbPercentage.Text, out value))
                {
                    return 0;
                }
                return value;
            }

            set
            {
                tbPercentage.Text = value.ToString();
            }
        }

        public int MaxValue { get; set; } = 100;
        public int MinValue { get; set; } = 0;
        public int OverrideFontSize { get; set; }
        
        public PercentBox()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Value = Value - 1;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            Value = Value + 1;
        }

        private void tbPercentage_TextChanged(object sender, EventArgs e)
        {
            if (tbPercentage.Text.Length == 0)
                return;

            btnLeft.Enabled = true;
            btnRight.Enabled = true;

            if (Value >= MaxValue)
            {
                tbPercentage.Text = MaxValue.ToString(); ;
                Value = MaxValue;
                btnRight.Enabled = false;
            }
            else if (Value <= MinValue)
            {
                tbPercentage.Text = MinValue.ToString();
                Value = MinValue;
                btnLeft.Enabled = false;
            }
        }

        private void tbPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SetCustomFont(FontFamily font)
        {
            tbPercentage.Font = new Font(font, OverrideFontSize > 0 ? OverrideFontSize : tbPercentage.Font.Size);
        }
    }
}
