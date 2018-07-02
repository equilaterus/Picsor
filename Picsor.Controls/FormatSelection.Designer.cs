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
            this.SuspendLayout();
            // 
            // btnJpg
            // 
            this.btnJpg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnJpg.FlatAppearance.BorderSize = 0;
            this.btnJpg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnJpg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnJpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJpg.ForeColor = System.Drawing.Color.Silver;
            this.btnJpg.Location = new System.Drawing.Point(154, 0);
            this.btnJpg.Name = "btnJpg";
            this.btnJpg.Size = new System.Drawing.Size(77, 25);
            this.btnJpg.TabIndex = 0;
            this.btnJpg.Text = "JPG";
            this.btnJpg.UseVisualStyleBackColor = false;
            this.btnJpg.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPng
            // 
            this.btnPng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnPng.FlatAppearance.BorderSize = 0;
            this.btnPng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnPng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPng.ForeColor = System.Drawing.Color.Silver;
            this.btnPng.Location = new System.Drawing.Point(80, 0);
            this.btnPng.Name = "btnPng";
            this.btnPng.Size = new System.Drawing.Size(72, 25);
            this.btnPng.TabIndex = 1;
            this.btnPng.Text = "PNG";
            this.btnPng.UseVisualStyleBackColor = false;
            this.btnPng.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPreserve
            // 
            this.btnPreserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnPreserve.FlatAppearance.BorderSize = 0;
            this.btnPreserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPreserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(105)))), ((int)(((byte)(53)))));
            this.btnPreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreserve.ForeColor = System.Drawing.Color.Silver;
            this.btnPreserve.Location = new System.Drawing.Point(0, 0);
            this.btnPreserve.Name = "btnPreserve";
            this.btnPreserve.Size = new System.Drawing.Size(79, 25);
            this.btnPreserve.TabIndex = 2;
            this.btnPreserve.Text = "Preserve";
            this.btnPreserve.UseVisualStyleBackColor = false;
            this.btnPreserve.Click += new System.EventHandler(this.Button_Click);
            // 
            // FormatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.btnPreserve);
            this.Controls.Add(this.btnPng);
            this.Controls.Add(this.btnJpg);
            this.Name = "FormatSelection";
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJpg;
        private System.Windows.Forms.Button btnPng;
        private System.Windows.Forms.Button btnPreserve;
    }
}
