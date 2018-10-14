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
    public partial class LoadingPanel : UserControl
    {
        public event EventHandler AcceptButton;

        public LoadingPanel()
        {
            InitializeComponent();
            Reset();
        }

        public void Completed()
        {
            lbLoading.Text = "We've finished!";
            lbResult.Visible = true;
            pbLoading.Visible = false;
            btnAccept.Visible = true;
        }

        private void Reset()
        {
            lbLoading.Text = "We are optimizing your images";
            lbResult.Visible = false;
            pbLoading.Visible = true;
            btnAccept.Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Reset();

            // Trigger event
            AcceptButton?.Invoke(sender, e);
        }
    }
}
