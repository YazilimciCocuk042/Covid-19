
namespace Covid_19
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.vaka = new System.Windows.Forms.Label();
            this.iyilesen = new System.Windows.Forms.Label();
            this.vefat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vaka Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "İyileşen Hasta Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vefat Sayısı:";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(263, 13);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(73, 30);
            this.tarih.TabIndex = 5;
            this.tarih.Text = "Tarih: ";
            this.tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.test.Location = new System.Drawing.Point(263, 43);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(73, 30);
            this.test.TabIndex = 6;
            this.test.Text = "Tarih: ";
            this.test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vaka
            // 
            this.vaka.AutoSize = true;
            this.vaka.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vaka.Location = new System.Drawing.Point(263, 73);
            this.vaka.Name = "vaka";
            this.vaka.Size = new System.Drawing.Size(73, 30);
            this.vaka.TabIndex = 7;
            this.vaka.Text = "Tarih: ";
            this.vaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iyilesen
            // 
            this.iyilesen.AutoSize = true;
            this.iyilesen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iyilesen.Location = new System.Drawing.Point(263, 103);
            this.iyilesen.Name = "iyilesen";
            this.iyilesen.Size = new System.Drawing.Size(73, 30);
            this.iyilesen.TabIndex = 8;
            this.iyilesen.Text = "Tarih: ";
            this.iyilesen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vefat
            // 
            this.vefat.AutoSize = true;
            this.vefat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vefat.Location = new System.Drawing.Point(263, 133);
            this.vefat.Name = "vefat";
            this.vefat.Size = new System.Drawing.Size(73, 30);
            this.vefat.TabIndex = 9;
            this.vefat.Text = "Tarih: ";
            this.vefat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 200);
            this.Controls.Add(this.vefat);
            this.Controls.Add(this.iyilesen);
            this.Controls.Add(this.vaka);
            this.Controls.Add(this.test);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid 19 - Günlük Türkiye Verileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label vaka;
        private System.Windows.Forms.Label iyilesen;
        private System.Windows.Forms.Label vefat;
    }
}

