namespace Picsor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn720 = new System.Windows.Forms.Button();
            this.btn1080 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btnExecute = new System.Windows.Forms.Button();
            this.listviewImages = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelPercentage = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSize = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picsorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imagesList = new System.Windows.Forms.ImageList(this.components);
            this.lbInstructions = new System.Windows.Forms.Label();
            this.lbPicsorInstuctions = new System.Windows.Forms.Label();
            this.loadingPanel = new Picsor.Controls.LoadingPanel();
            this.pbPercent = new Picsor.Controls.PercentBox();
            this.pbMaxWidth = new Picsor.Controls.PercentBox();
            this.pbMaxHeight = new Picsor.Controls.PercentBox();
            this.resizingSelection = new Picsor.Controls.ResizingSelection();
            this.formatSelection = new Picsor.Controls.FormatSelection();
            this.pbQuality = new Picsor.Controls.PercentBox();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelPercentage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.btn720);
            this.panel1.Controls.Add(this.btn1080);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 528);
            this.panel1.TabIndex = 0;
            // 
            // btn720
            // 
            this.btn720.FlatAppearance.BorderSize = 0;
            this.btn720.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn720.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn720.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn720.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn720.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn720.Location = new System.Drawing.Point(3, 67);
            this.btn720.Name = "btn720";
            this.btn720.Size = new System.Drawing.Size(158, 35);
            this.btn720.TabIndex = 1;
            this.btn720.Text = "720 Web";
            this.btn720.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn720.UseVisualStyleBackColor = true;
            this.btn720.Click += new System.EventHandler(this.btn720_Click);
            // 
            // btn1080
            // 
            this.btn1080.FlatAppearance.BorderSize = 0;
            this.btn1080.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn1080.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn1080.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1080.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1080.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1080.Location = new System.Drawing.Point(3, 26);
            this.btn1080.Name = "btn1080";
            this.btn1080.Size = new System.Drawing.Size(158, 35);
            this.btn1080.TabIndex = 0;
            this.btn1080.Text = "1080 Web";
            this.btn1080.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1080.UseVisualStyleBackColor = true;
            this.btn1080.Click += new System.EventHandler(this.btn1080_Click);
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(775, 31);
            this.panelTop.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(733, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PICSOR";
            // 
            // panelProfile
            // 
            this.panelProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfile.Controls.Add(this.lbPicsorInstuctions);
            this.panelProfile.Controls.Add(this.lbInstructions);
            this.panelProfile.Controls.Add(this.btnExecute);
            this.panelProfile.Controls.Add(this.listviewImages);
            this.panelProfile.Controls.Add(this.btnSearch);
            this.panelProfile.Controls.Add(this.panel5);
            this.panelProfile.Controls.Add(this.panel4);
            this.panelProfile.Location = new System.Drawing.Point(173, 3);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(597, 528);
            this.panelProfile.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(17)))));
            this.btnExecute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExecute.Location = new System.Drawing.Point(33, 473);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(528, 35);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Done";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // listviewImages
            // 
            this.listviewImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listviewImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listviewImages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listviewImages.HideSelection = false;
            this.listviewImages.Location = new System.Drawing.Point(24, 293);
            this.listviewImages.Margin = new System.Windows.Forms.Padding(0);
            this.listviewImages.MultiSelect = false;
            this.listviewImages.Name = "listviewImages";
            this.listviewImages.Size = new System.Drawing.Size(546, 161);
            this.listviewImages.TabIndex = 0;
            this.listviewImages.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(17)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Location = new System.Drawing.Point(33, 240);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(528, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Select files";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.panelPercentage);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panelSize);
            this.panel5.Controls.Add(this.resizingSelection);
            this.panel5.Location = new System.Drawing.Point(24, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 197);
            this.panel5.TabIndex = 0;
            // 
            // panelPercentage
            // 
            this.panelPercentage.Controls.Add(this.pbPercent);
            this.panelPercentage.Controls.Add(this.label11);
            this.panelPercentage.Location = new System.Drawing.Point(94, 96);
            this.panelPercentage.Name = "panelPercentage";
            this.panelPercentage.Size = new System.Drawing.Size(126, 100);
            this.panelPercentage.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(22, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Percent (%)";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 43);
            this.panel6.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resizing mode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.pbMaxWidth);
            this.panelSize.Controls.Add(this.label7);
            this.panelSize.Controls.Add(this.label8);
            this.panelSize.Controls.Add(this.pbMaxHeight);
            this.panelSize.Location = new System.Drawing.Point(9, 91);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(292, 88);
            this.panelSize.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label7.Location = new System.Drawing.Point(24, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max Width (px)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label8.Location = new System.Drawing.Point(173, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Max height (px)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.formatSelection);
            this.panel4.Controls.Add(this.pbQuality);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(342, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 197);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(228, 43);
            this.panel7.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Encoding";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.label6.Location = new System.Drawing.Point(86, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quality";
            // 
            // picsorBackgroundWorker
            // 
            this.picsorBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.picsorBackgroundWorker_DoWork);
            this.picsorBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.picsorBackgroundWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelProfile, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 534);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // imagesList
            // 
            this.imagesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imagesList.ImageSize = new System.Drawing.Size(64, 64);
            this.imagesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbInstructions
            // 
            this.lbInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lbInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lbInstructions.Location = new System.Drawing.Point(38, 347);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(496, 80);
            this.lbInstructions.TabIndex = 6;
            this.lbInstructions.Text = "Select and customize a profile, then browse the images to optimize. We will conve" +
    "rt them creating a copy on different folder, always protecting your data!";
            // 
            // lbPicsorInstuctions
            // 
            this.lbPicsorInstuctions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lbPicsorInstuctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPicsorInstuctions.ForeColor = System.Drawing.Color.Gray;
            this.lbPicsorInstuctions.Location = new System.Drawing.Point(38, 307);
            this.lbPicsorInstuctions.Name = "lbPicsorInstuctions";
            this.lbPicsorInstuctions.Size = new System.Drawing.Size(523, 29);
            this.lbPicsorInstuctions.TabIndex = 7;
            this.lbPicsorInstuctions.Text = "Picsor instructions";
            // 
            // loadingPanel
            // 
            this.loadingPanel.AutoSize = true;
            this.loadingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loadingPanel.Location = new System.Drawing.Point(170, 75);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(624, 240);
            this.loadingPanel.TabIndex = 6;
            // 
            // pbPercent
            // 
            this.pbPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbPercent.Location = new System.Drawing.Point(3, 3);
            this.pbPercent.MaxValue = 100;
            this.pbPercent.MinValue = 0;
            this.pbPercent.Name = "pbPercent";
            this.pbPercent.OverrideFontSize = 0;
            this.pbPercent.Size = new System.Drawing.Size(119, 44);
            this.pbPercent.TabIndex = 0;
            this.pbPercent.Value = 100;
            // 
            // pbMaxWidth
            // 
            this.pbMaxWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbMaxWidth.Location = new System.Drawing.Point(6, 7);
            this.pbMaxWidth.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbMaxWidth.MaxValue = 9999;
            this.pbMaxWidth.MinValue = 0;
            this.pbMaxWidth.Name = "pbMaxWidth";
            this.pbMaxWidth.OverrideFontSize = 22;
            this.pbMaxWidth.Size = new System.Drawing.Size(131, 44);
            this.pbMaxWidth.TabIndex = 0;
            this.pbMaxWidth.Value = 9998;
            // 
            // pbMaxHeight
            // 
            this.pbMaxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbMaxHeight.Location = new System.Drawing.Point(156, 7);
            this.pbMaxHeight.MaxValue = 9999;
            this.pbMaxHeight.MinValue = 0;
            this.pbMaxHeight.Name = "pbMaxHeight";
            this.pbMaxHeight.OverrideFontSize = 22;
            this.pbMaxHeight.Size = new System.Drawing.Size(131, 44);
            this.pbMaxHeight.TabIndex = 1;
            this.pbMaxHeight.Value = 9998;
            // 
            // resizingSelection
            // 
            this.resizingSelection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizingSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.resizingSelection.Location = new System.Drawing.Point(9, 49);
            this.resizingSelection.Name = "resizingSelection";
            this.resizingSelection.Size = new System.Drawing.Size(292, 43);
            this.resizingSelection.TabIndex = 0;
            this.resizingSelection.Click += new System.EventHandler(this.resizingSelection_Click);
            // 
            // formatSelection
            // 
            this.formatSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.formatSelection.Location = new System.Drawing.Point(7, 49);
            this.formatSelection.Name = "formatSelection";
            this.formatSelection.Size = new System.Drawing.Size(212, 43);
            this.formatSelection.TabIndex = 0;
            // 
            // pbQuality
            // 
            this.pbQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pbQuality.Location = new System.Drawing.Point(53, 99);
            this.pbQuality.MaxValue = 100;
            this.pbQuality.MinValue = 0;
            this.pbQuality.Name = "pbQuality";
            this.pbQuality.OverrideFontSize = 0;
            this.pbQuality.Size = new System.Drawing.Size(119, 44);
            this.pbQuality.TabIndex = 1;
            this.pbQuality.Value = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(774, 558);
            this.Controls.Add(this.loadingPanel);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(765, 530);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelPercentage.ResumeLayout(false);
            this.panelPercentage.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private Controls.PercentBox pbQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn720;
        private System.Windows.Forms.Button btn1080;
        private Controls.PercentBox pbPercent;
        private Controls.PercentBox pbMaxHeight;
        private System.Windows.Forms.Label label11;
        private Controls.PercentBox pbMaxWidth;
        private System.ComponentModel.BackgroundWorker picsorBackgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Controls.ResizingSelection resizingSelection;
        private Controls.FormatSelection formatSelection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelPercentage;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.ListView listviewImages;
        private System.Windows.Forms.ImageList imagesList;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private Controls.LoadingPanel loadingPanel;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Label lbPicsorInstuctions;
    }
}

