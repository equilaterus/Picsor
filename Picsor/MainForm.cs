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
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {   
            InitializeComponent();

            resizingSelection_Click(null, null);
            resizingSelection.ButtonChanged += new EventHandler(resizingSelection_Click);

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
                    customizableControl.SetCustomFont(_Pfc.Families[0]);
                }
                else
                {
                    if (control.Name == "btnClose") continue;
                    control.Font = new Font(_Pfc.Families[0], control.Font.Size);
                    CustomizeControls(control.Controls);
                }
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            _Pfc = LoadFont(Properties.Resources.BaiJamjuree_Regular);

            CustomizeControls(Controls);
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            imagesList.Images.Clear();
            listviewImages.Clear();
            for (int i = 0; i < openFileDialog.FileNames.Count(); i++)
            {
                try
                {
                    var path = openFileDialog.FileNames[i];
                    imagesList.Images.Add(Image.FromFile(path));
                    listviewImages.Items.Add(
                        new ListViewItem
                        {
                            ImageIndex = i,
                            Text = path.Substring(path.LastIndexOf('\\') + 1)
                        });

                }
                catch
                {
                    MessageBox.Show("Error");
                }
                
            }

            listviewImages.LargeImageList = imagesList;
        }

        private void btnExecute_Click(object sender, EventArgs e)
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

            foreach (var file in openFileDialog.FileNames)
            {
                ImageCompressor imageCompressor = new ImageCompressor(new Bitmap(file));

                // Type of resizing
                Bitmap resized = null;
                if(panelSize.Visible == true)
                {
                    resized = imageCompressor.ResizeMaxDimensions(pbMaxWidth.Value, pbMaxheight.Value);
                }
                if(panelPercentage.Visible == true)
                {
                    resized = imageCompressor.ResizePercentage(pbPercent.Value / 100f);
                }

                // Define forced codec 
                ImageCodecInfo codec = null;
                
                if (formatSelection.Current.Text == "JPG")
                {
                    codec = imageCompressor.GetCodec(ImageFormat.Jpeg);
                }
                else if (formatSelection.Current.Text == "PNG")
                {
                    codec = imageCompressor.GetCodec(ImageFormat.Png);                    
                }

                // Update output filename for forced codec
                string outputFilename = file.Substring(file.LastIndexOf('\\') + 1);
                if (codec != null)
                {
                    outputFilename += $".{formatSelection.Current.Text}";
                }
                // Or keep current codec
                else
                {
                    codec = imageCompressor.GetCurrentCodec();
                }
                
                // Encode and save
                imageCompressor.EncodeAndSave(
                    codec,
                    directory + "\\" + outputFilename,
                    pbQuality.Value, 
                    resized);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resizingSelection_Click(object sender, EventArgs e)
        {
            if (resizingSelection.Current.Text == "Size")
            {
                panelSize.Visible = true;
                panelPercentage.Visible = false;
            }
            else
            {
                panelSize.Visible = false;
                panelPercentage.Visible = true;
            }
        }
    }
}
