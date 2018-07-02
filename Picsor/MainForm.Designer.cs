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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.picsorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbMaxheight = new Picsor.Controls.PercentBox();
            this.pbMaxWidth = new Picsor.Controls.PercentBox();
            this.pbPercent = new Picsor.Controls.PercentBox();
            this.pbQuality = new Picsor.Controls.PercentBox();
            this.formatSelection = new Picsor.Controls.FormatSelection();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 525);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.Location = new System.Drawing.Point(3, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 35);
            this.button6.TabIndex = 9;
            this.button6.Text = "Profile 2";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(0, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "New +";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(3, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "Profile 1";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Location = new System.Drawing.Point(0, -2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(851, 34);
            this.panelTop.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(38)))), ((int)(((byte)(24)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(809, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Picsor";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(172, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 488);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(273, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número de archivos...";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(10, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(635, 35);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(272, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Encoding";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(17)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Location = new System.Drawing.Point(227, 426);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pbMaxheight);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.pbMaxWidth);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.pbPercent);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btnSize);
            this.panel5.Controls.Add(this.btnPercentage);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(10, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(635, 190);
            this.panel5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(482, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Max height (px)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(295, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max Width (px)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(92, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Percent (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(295, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Size Based";
            // 
            // btnSize
            // 
            this.btnSize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(17)))));
            this.btnSize.FlatAppearance.BorderSize = 2;
            this.btnSize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(50)))));
            this.btnSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSize.Location = new System.Drawing.Point(263, 56);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(20, 20);
            this.btnSize.TabIndex = 7;
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(17)))));
            this.btnPercentage.FlatAppearance.BorderSize = 2;
            this.btnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercentage.Location = new System.Drawing.Point(19, 56);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(20, 20);
            this.btnPercentage.TabIndex = 6;
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(50, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Percentage Based";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 35);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(265, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resizing";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel4.Controls.Add(this.formatSelection);
            this.panel4.Controls.Add(this.pbQuality);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(10, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 200);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(288, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quality";
            // 
            // picsorBackgroundWorker
            // 
            this.picsorBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.picsorBackgroundWorker_DoWork);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            // 
            // pbMaxheight
            // 
            this.pbMaxheight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pbMaxheight.Location = new System.Drawing.Point(452, 95);
            this.pbMaxheight.MaxValue = 9999;
            this.pbMaxheight.MinValue = 0;
            this.pbMaxheight.Name = "pbMaxheight";
            this.pbMaxheight.Size = new System.Drawing.Size(166, 70);
            this.pbMaxheight.TabIndex = 12;
            this.pbMaxheight.Value = 9998;
            // 
            // pbMaxWidth
            // 
            this.pbMaxWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pbMaxWidth.Location = new System.Drawing.Point(263, 95);
            this.pbMaxWidth.MaxValue = 9999;
            this.pbMaxWidth.MinValue = 0;
            this.pbMaxWidth.Name = "pbMaxWidth";
            this.pbMaxWidth.Size = new System.Drawing.Size(166, 70);
            this.pbMaxWidth.TabIndex = 11;
            this.pbMaxWidth.Value = 9998;
            // 
            // pbPercent
            // 
            this.pbPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pbPercent.Location = new System.Drawing.Point(53, 95);
            this.pbPercent.MaxValue = 100;
            this.pbPercent.MinValue = 0;
            this.pbPercent.Name = "pbPercent";
            this.pbPercent.Size = new System.Drawing.Size(134, 70);
            this.pbPercent.TabIndex = 9;
            this.pbPercent.Value = 100;
            // 
            // pbQuality
            // 
            this.pbQuality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pbQuality.Location = new System.Drawing.Point(229, 97);
            this.pbQuality.MaxValue = 100;
            this.pbQuality.MinValue = 0;
            this.pbQuality.Name = "pbQuality";
            this.pbQuality.Size = new System.Drawing.Size(166, 66);
            this.pbQuality.TabIndex = 4;
            this.pbQuality.Value = 100;
            // 
            // formatSelection
            // 
            this.formatSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.formatSelection.Location = new System.Drawing.Point(188, 61);
            this.formatSelection.Name = "formatSelection";
            this.formatSelection.Size = new System.Drawing.Size(250, 30);
            this.formatSelection.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(850, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(850, 530);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Controls.PercentBox pbQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Controls.PercentBox pbPercent;
        private Controls.PercentBox pbMaxWidth;
        private System.Windows.Forms.Label label11;
        private Controls.PercentBox pbMaxheight;
        private System.ComponentModel.BackgroundWorker picsorBackgroundWorker;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Controls.FormatSelection formatSelection;
    }
}

