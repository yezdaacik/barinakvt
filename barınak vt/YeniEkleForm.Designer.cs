namespace barınak_vt
{
    partial class YeniEkleForm
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtİsimEkle = new System.Windows.Forms.TextBox();
            this.txtYasEkle = new System.Windows.Forms.TextBox();
            this.cbEngelDurumu = new System.Windows.Forms.CheckBox();
            this.cmbCinsEkle = new System.Windows.Forms.ComboBox();
            this.pbResimEkle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(32, 183);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 68);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yaşı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cinsi";
            // 
            // txtİsimEkle
            // 
            this.txtİsimEkle.Location = new System.Drawing.Point(71, 31);
            this.txtİsimEkle.Name = "txtİsimEkle";
            this.txtİsimEkle.Size = new System.Drawing.Size(127, 20);
            this.txtİsimEkle.TabIndex = 4;
            // 
            // txtYasEkle
            // 
            this.txtYasEkle.Location = new System.Drawing.Point(71, 62);
            this.txtYasEkle.Name = "txtYasEkle";
            this.txtYasEkle.Size = new System.Drawing.Size(127, 20);
            this.txtYasEkle.TabIndex = 5;
            // 
            // cbEngelDurumu
            // 
            this.cbEngelDurumu.AutoSize = true;
            this.cbEngelDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEngelDurumu.Location = new System.Drawing.Point(71, 128);
            this.cbEngelDurumu.Name = "cbEngelDurumu";
            this.cbEngelDurumu.Size = new System.Drawing.Size(110, 20);
            this.cbEngelDurumu.TabIndex = 6;
            this.cbEngelDurumu.Text = "Engel Durumu";
            this.cbEngelDurumu.UseVisualStyleBackColor = true;
            // 
            // cmbCinsEkle
            // 
            this.cmbCinsEkle.FormattingEnabled = true;
            this.cmbCinsEkle.Location = new System.Drawing.Point(71, 88);
            this.cmbCinsEkle.Name = "cmbCinsEkle";
            this.cmbCinsEkle.Size = new System.Drawing.Size(127, 21);
            this.cmbCinsEkle.TabIndex = 7;
            // 
            // pbResimEkle
            // 
            this.pbResimEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbResimEkle.Location = new System.Drawing.Point(250, 28);
            this.pbResimEkle.Name = "pbResimEkle";
            this.pbResimEkle.Size = new System.Drawing.Size(160, 223);
            this.pbResimEkle.TabIndex = 8;
            this.pbResimEkle.TabStop = false;
            this.pbResimEkle.Click += new System.EventHandler(this.pbResimEkle_Click);
            // 
            // YeniEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 312);
            this.Controls.Add(this.pbResimEkle);
            this.Controls.Add(this.cmbCinsEkle);
            this.Controls.Add(this.cbEngelDurumu);
            this.Controls.Add(this.txtYasEkle);
            this.Controls.Add(this.txtİsimEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Name = "YeniEkleForm";
            this.Text = "YeniEkleForm";
            this.Load += new System.EventHandler(this.YeniEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtİsimEkle;
        private System.Windows.Forms.TextBox txtYasEkle;
        private System.Windows.Forms.CheckBox cbEngelDurumu;
        private System.Windows.Forms.ComboBox cmbCinsEkle;
        private System.Windows.Forms.PictureBox pbResimEkle;
    }
}