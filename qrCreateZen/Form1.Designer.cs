namespace qrCreateZen
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pcQR = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMasaustuKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcQR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtValue.Location = new System.Drawing.Point(130, 25);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(346, 36);
            this.txtValue.TabIndex = 0;
            this.txtValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValue_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEXT:";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(483, 25);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(113, 36);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "OLUŞTUR";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "QR\'a çevirmek istediğiniz text değerini yukarı yazıp oluştura basınız.";
            // 
            // pcQR
            // 
            this.pcQR.Location = new System.Drawing.Point(157, 107);
            this.pcQR.Name = "pcQR";
            this.pcQR.Size = new System.Drawing.Size(300, 300);
            this.pcQR.TabIndex = 4;
            this.pcQR.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "QR:";
            // 
            // btnMasaustuKaydet
            // 
            this.btnMasaustuKaydet.Location = new System.Drawing.Point(157, 433);
            this.btnMasaustuKaydet.Name = "btnMasaustuKaydet";
            this.btnMasaustuKaydet.Size = new System.Drawing.Size(300, 36);
            this.btnMasaustuKaydet.TabIndex = 6;
            this.btnMasaustuKaydet.Text = "MASAÜSTÜNE KAYDET";
            this.btnMasaustuKaydet.UseVisualStyleBackColor = true;
            this.btnMasaustuKaydet.Click += new System.EventHandler(this.btnMasaustuKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 496);
            this.Controls.Add(this.btnMasaustuKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcQR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QR OLUŞTURUCU";
            ((System.ComponentModel.ISupportInitialize)(this.pcQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcQR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMasaustuKaydet;
    }
}

