namespace BT2
{
    partial class frmCaculator
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.bntCong = new System.Windows.Forms.Button();
            this.bntTru = new System.Windows.Forms.Button();
            this.bntNhan = new System.Windows.Forms.Button();
            this.bntChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(61, 51);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(100, 20);
            this.txtSo1.TabIndex = 0;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(330, 50);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(100, 20);
            this.txtSo2.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(202, 117);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 2;
            // 
            // bntCong
            // 
            this.bntCong.Location = new System.Drawing.Point(37, 171);
            this.bntCong.Name = "bntCong";
            this.bntCong.Size = new System.Drawing.Size(75, 23);
            this.bntCong.TabIndex = 3;
            this.bntCong.Text = "Cộng";
            this.bntCong.UseVisualStyleBackColor = true;
            this.bntCong.Click += new System.EventHandler(this.bntCong_Click);
            // 
            // bntTru
            // 
            this.bntTru.Location = new System.Drawing.Point(152, 171);
            this.bntTru.Name = "bntTru";
            this.bntTru.Size = new System.Drawing.Size(75, 23);
            this.bntTru.TabIndex = 4;
            this.bntTru.Text = "Trừ";
            this.bntTru.UseVisualStyleBackColor = true;
            this.bntTru.Click += new System.EventHandler(this.bntTru_Click);
            // 
            // bntNhan
            // 
            this.bntNhan.Location = new System.Drawing.Point(270, 171);
            this.bntNhan.Name = "bntNhan";
            this.bntNhan.Size = new System.Drawing.Size(75, 23);
            this.bntNhan.TabIndex = 5;
            this.bntNhan.Text = "Nhân";
            this.bntNhan.UseVisualStyleBackColor = true;
            this.bntNhan.Click += new System.EventHandler(this.bntNhan_Click);
            // 
            // bntChia
            // 
            this.bntChia.Location = new System.Drawing.Point(383, 171);
            this.bntChia.Name = "bntChia";
            this.bntChia.Size = new System.Drawing.Size(75, 23);
            this.bntChia.TabIndex = 6;
            this.bntChia.Text = "Chia";
            this.bntChia.UseVisualStyleBackColor = true;
            this.bntChia.Click += new System.EventHandler(this.bntChia_Click);
            // 
            // frmCaculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 261);
            this.Controls.Add(this.bntChia);
            this.Controls.Add(this.bntNhan);
            this.Controls.Add(this.bntTru);
            this.Controls.Add(this.bntCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Name = "frmCaculator";
            this.Text = "frmCaculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button bntCong;
        private System.Windows.Forms.Button bntTru;
        private System.Windows.Forms.Button bntNhan;
        private System.Windows.Forms.Button bntChia;
    }
}

