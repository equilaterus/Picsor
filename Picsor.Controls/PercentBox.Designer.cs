namespace Picsor.Controls
{
    partial class PercentBox
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.tbPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.Silver;
            this.btnLeft.Location = new System.Drawing.Point(0, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(20, 54);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "◄";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.Silver;
            this.btnRight.Location = new System.Drawing.Point(160, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnRight.Size = new System.Drawing.Size(20, 54);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "►";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // tbPercentage
            // 
            this.tbPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tbPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPercentage.ForeColor = System.Drawing.Color.Silver;
            this.tbPercentage.Location = new System.Drawing.Point(20, 0);
            this.tbPercentage.Name = "tbPercentage";
            this.tbPercentage.Size = new System.Drawing.Size(140, 60);
            this.tbPercentage.TabIndex = 2;
            this.tbPercentage.Text = "100";
            this.tbPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPercentage.TextChanged += new System.EventHandler(this.tbPercentage_TextChanged);
            this.tbPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPercentage_KeyPress);
            // 
            // PercentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.tbPercentage);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Name = "PercentBox";
            this.Size = new System.Drawing.Size(180, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox tbPercentage;
    }
}
