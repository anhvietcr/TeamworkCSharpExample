namespace FrmMain
{
    partial class FrmMain
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
            this.btnOpenFrmGV = new System.Windows.Forms.Button();
            this.btnOpenFrmHV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenFrmGV
            // 
            this.btnOpenFrmGV.Location = new System.Drawing.Point(59, 102);
            this.btnOpenFrmGV.Name = "btnOpenFrmGV";
            this.btnOpenFrmGV.Size = new System.Drawing.Size(75, 44);
            this.btnOpenFrmGV.TabIndex = 0;
            this.btnOpenFrmGV.Text = "Giáo Viên";
            this.btnOpenFrmGV.UseVisualStyleBackColor = true;
            this.btnOpenFrmGV.Click += new System.EventHandler(this.btnOpenFrmGV_Click);
            // 
            // btnOpenFrmHV
            // 
            this.btnOpenFrmHV.Location = new System.Drawing.Point(217, 102);
            this.btnOpenFrmHV.Name = "btnOpenFrmHV";
            this.btnOpenFrmHV.Size = new System.Drawing.Size(75, 44);
            this.btnOpenFrmHV.TabIndex = 0;
            this.btnOpenFrmHV.Text = "Học Viên";
            this.btnOpenFrmHV.UseVisualStyleBackColor = true;
            this.btnOpenFrmHV.Click += new System.EventHandler(this.btnOpenFrmHV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 68);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 184);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpenFrmHV);
            this.Controls.Add(this.btnOpenFrmGV);
            this.MaximumSize = new System.Drawing.Size(378, 223);
            this.MinimumSize = new System.Drawing.Size(378, 223);
            this.Name = "FrmMain";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFrmGV;
        private System.Windows.Forms.Button btnOpenFrmHV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

