using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Picsor.Controls
{
    public partial class LoadingPanel : UserControl
    {
        public event EventHandler AcceptButton;

        private string _folder;

        public LoadingPanel()
        {
            InitializeComponent();
            Reset();
        }

        public void Completed(string folder)
        {
            _folder = folder;

            lbLoading.Text = "We've finished!";
            lbResult.Visible = true;
            pbLoading.Visible = false;
            btnOpen.Visible = true;
            btnAccept.Visible = true;
        }

        private void Reset()
        {
            lbLoading.Text = "We are optimizing your images";
            lbResult.Visible = false;
            pbLoading.Visible = true;
            btnOpen.Visible = false;
            btnAccept.Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Reset();

            // Trigger event
            AcceptButton?.Invoke(sender, e);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Reset();

            Process.Start("explorer.exe", _folder);

            // Trigger event
            AcceptButton?.Invoke(sender, e);
        }
    }
}
