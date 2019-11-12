namespace WindowsFormsApplication1
{
    partial class themmonan
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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.tbxTenMon = new System.Windows.Forms.TextBox();
            this.tbxGiaTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTenMon.Location = new System.Drawing.Point(12, 24);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(105, 25);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Ten Mon:";
          
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(15, 69);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(101, 25);
            this.lblGiaTien.TabIndex = 1;
            this.lblGiaTien.Text = "Gia Tien:";
            // 
            // tbxTenMon
            // 
            this.tbxTenMon.Location = new System.Drawing.Point(123, 28);
            this.tbxTenMon.Name = "tbxTenMon";
            this.tbxTenMon.Size = new System.Drawing.Size(142, 20);
            this.tbxTenMon.TabIndex = 2;
            // 
            // tbxGiaTien
            // 
            this.tbxGiaTien.Location = new System.Drawing.Point(122, 73);
            this.tbxGiaTien.Name = "tbxGiaTien";
            this.tbxGiaTien.Size = new System.Drawing.Size(143, 20);
            this.tbxGiaTien.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(79, 129);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 35);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // themmonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 190);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbxGiaTien);
            this.Controls.Add(this.tbxTenMon);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenMon);
            this.Name = "themmonan";
            this.Text = "themmonan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.TextBox tbxTenMon;
        private System.Windows.Forms.TextBox tbxGiaTien;
        private System.Windows.Forms.Button btnLuu;
    }
}