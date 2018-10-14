namespace Picsor.Controls
{
    partial class FormatSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJpg = new System.Windows.Forms.Button();
            this.btnPng = new System.Windows.Forms.Button();
            this.btnPreserve = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJpg
            // 
            this.btnJpg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnJpg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJpg.FlatAppearance.BorderSize = 0;
            this.btnJpg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnJpg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnJpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJpg.ForeColor = System.Drawing.Color.Silver;
            this.btnJpg.Location = new System.Drawing.Point(273, 3);
            this.btnJpg.Name = "btnJpg";
            this.btnJpg.Size = new System.Drawing.Size(129, 43);
            this.btnJpg.TabIndex = 0;
            this.btnJpg.Text = "JPG";
            this.btnJpg.UseVisualStyleBackColor = false;
            this.btnJpg.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPng
            // 
            this.btnPng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPng.FlatAppearance.BorderSize = 0;
            this.btnPng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnPng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPng.ForeColor = System.Drawing.Color.Silver;
            this.btnPng.Location = new System.Drawing.Point(138, 3);
            this.btnPng.Name = "btnPng";
            this.btnPng.Size = new System.Drawing.Size(129, 43);
            this.btnPng.TabIndex = 1;
            this.btnPng.Text = "PNG";
            this.btnPng.UseVisualStyleBackColor = false;
            this.btnPng.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPreserve
            // 
            this.btnPreserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPreserve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreserve.FlatAppearance.BorderSize = 0;
            this.btnPreserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPreserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnPreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreserve.ForeColor = System.Drawing.Color.Silver;
            this.btnPreserve.Location = new System.Drawing.Point(3, 3);
            this.btnPreserve.Name = "btnPreserve";
            this.btnPreserve.Size = new System.Drawing.Size(129, 43);
            this.btnPreserve.TabIndex = 2;
            this.btnPreserve.Text = "Keep";
            this.btnPreserve.UseVisualStyleBackColor = false;
            this.btnPreserve.Click += new System.EventHandler(this.Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnPreserve, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnJpg, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPng, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 49);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FormatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormatSelection";
            this.Size = new System.Drawing.Size(405, 49);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJpg;
        private System.Windows.Forms.Button btnPng;
        private System.Windows.Forms.Button btnPreserve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
