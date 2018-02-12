using Picsor.Compressor;
using Picsor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
                else
                {
                    control.Font = new Font(_Pfc.Families[0], control.Font.Size);
                    CustomizeControls(control.Controls);
                }
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

        private void ExecuteCompression()
        {
            picsorBackgroundWorker.RunWorkerAsync();
        }

        private void picsorBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string directory = openFileDialog
                .FileName.Substring(0, openFileDialog.FileName.LastIndexOf('\\'))
                                  + "\\Converted";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // TODO SET PARAMS
            int width = 0;
            int height = 0;
            int quality = 0;

            foreach (var file in openFileDialog.FileNames)
            {
                ImageCompressor imageCompressor = new ImageCompressor(new Bitmap(file));

                // Force codec
                var codec = imageCompressor.GetCodec(ImageFormat.Jpeg);
                codec = imageCompressor.GetCodec(ImageFormat.Png);
                // Keep current
                codec = imageCompressor.GetCurrentCodec();

                // Type of resizing
                Bitmap resized = null; // Null for original size
                resized = imageCompressor.ResizeMaxDimensions(width, height);
                resized = imageCompressor.ResizePercentage(0.0f / 100f);

                // Encode and save
                imageCompressor.EncodeAndSave(
                    codec,
                    directory + "\\" + file.Substring(file.LastIndexOf('\\') + 1),
                    quality, 
                    resized);

            }
        }
    }
}
