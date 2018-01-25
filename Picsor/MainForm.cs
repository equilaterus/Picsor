using Picsor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picsor
{
    public partial class MainForm : PicsorForm
    {
        public MainForm()
        {   
            InitializeComponent();

            panelTop.MouseDown += new MouseEventHandler(Form_MouseDown);
            panelTop.MouseUp += new MouseEventHandler(Form_MouseUp);
            panelTop.MouseMove += new MouseEventHandler(Form_MouseMove);
        }

        private PrivateFontCollection _Pfc;

        private void CustomizeControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                var customizableControl = control as IFontCustomizable;
                if (customizableControl != null)
                {
                    customizableControl.SetCustomFont(_Pfc.Families[0], 40);
                }

                CustomizeControls(control.Controls);
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            _Pfc = LoadFont(Properties.Resources.Dosis_Regular);

            CustomizeControls(Controls);
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
