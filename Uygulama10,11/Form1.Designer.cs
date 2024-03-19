namespace Uygulama10_11
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir Adı";
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(144, 121);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSehirAdi.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(261, 119);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(81, 184);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 173);
            this.lbListe.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(234, 224);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 43);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ArrayList Uygulama 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnListele;
    }
}

