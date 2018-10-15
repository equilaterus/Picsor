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
    public partial class FormatSelection : MultiButton
    {
        public FormatSelection()
        {
            InitializeComponent();
            SetDefault(btnPreserve);
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            base.HandleMultiButton_Click(sender, e);
        }

        public void SetCurrent(string text)
        {
            switch (text)
            {
                case "JPG": btnJpg.PerformClick();      break;
                case "PNG": btnPng.PerformClick();      break;
                default:    btnPreserve.PerformClick(); break;
            }
        }
    }
}
