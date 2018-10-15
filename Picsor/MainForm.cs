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

            
            loadingPanel.AcceptButton += new EventHandler(AcceptResults);            
            resizingSelection.ButtonChanged += new EventHandler(resizingSelection_Click);           

            panelTop.MouseDown += new MouseEventHandler(Form_MouseDown);
            panelTop.MouseUp += new MouseEventHandler(Form_MouseUp);
            panelTop.MouseMove += new MouseEventHandler(Form_MouseMove);
        }

        private PrivateFontCollection _Pfc;

        private string _directory;

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
            loadingPanel.Visible = false;
            listviewImages.Visible = false;
            btnExecute.Visible = false;

            _Pfc = LoadFont(Properties.Resources.BaiJamjuree_Regular);

            CustomizeControls(Controls);

            resizingSelection_Click(null, null);
            btn1080_Click(null, null);
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

        private void ClearImages()
        {
            imagesList.Images.Clear();
            listviewImages.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            ClearImages();
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

            lbInstructions.Visible = false;
            lbPicsorInstuctions.Visible = false;
            listviewImages.Visible = true;
            btnExecute.Visible = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            panelProfile.Visible = false;
            loadingPanel.Visible = true;
            btn1080.Visible = false;
            btn720.Visible = false;            
            picsorBackgroundWorker.RunWorkerAsync();
        }

        private void picsorBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingPanel.Completed(_directory);
        }

        private void AcceptResults(object sender, EventArgs e)
        {
            listviewImages.Visible = false;
            btnExecute.Visible = false;
            panelProfile.Visible = true;
            loadingPanel.Visible = false;
            btn1080.Visible = true;
            btn720.Visible = true;            
            ClearImages();
        }

        private void picsorBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _directory = openFileDialog
                .FileName.Substring(0, openFileDialog.FileName.LastIndexOf('\\'))
                                  + "\\PicsorConverted";

            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }

            foreach (var file in openFileDialog.FileNames)
            {
                ImageCompressor imageCompressor = new ImageCompressor(new Bitmap(file));

                // Type of resizing
                Bitmap resized = null;
                if(resizingSelection.Current.Text == "Size")
                {
                    resized = imageCompressor.GetResizeUsingMaxDimensions(pbMaxWidth.Value, pbMaxHeight.Value);
                }
                else if (pbPercent.Value != 100)
                {
                    resized = imageCompressor.GetResizedUsingPercentage(pbPercent.Value / 100f);
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
                    _directory + "\\" + outputFilename,
                    pbQuality.Value, 
                    resized);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn1080_Click(object sender, EventArgs e)
        {
            resizingSelection.SetCurrent("Size");
            pbMaxWidth.Value = 1920;
            pbMaxHeight.Value = 1080;

            formatSelection.SetCurrent("Keep");
            pbQuality.Value = 90;
        }

        private void btn720_Click(object sender, EventArgs e)
        {
            resizingSelection.SetCurrent("Size");
            pbMaxWidth.Value = 1280;
            pbMaxHeight.Value = 720;

            formatSelection.SetCurrent("Keep");
            pbQuality.Value = 80;
        }
    }
}
