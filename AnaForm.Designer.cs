namespace FormdanFormaVeriAktarma
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.btn_fonayarla = new System.Windows.Forms.Button();
            this.btn_renkayarla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Location = new System.Drawing.Point(100, 83);
            this.txt_soyadi.Multiline = true;
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(125, 20);
            this.txt_soyadi.TabIndex = 1;
            // 
            // btn_fonayarla
            // 
            this.btn_fonayarla.Location = new System.Drawing.Point(77, 194);
            this.btn_fonayarla.Name = "btn_fonayarla";
            this.btn_fonayarla.Size = new System.Drawing.Size(75, 23);
            this.btn_fonayarla.TabIndex = 2;
            this.btn_fonayarla.Text = "Fon Ayarla";
            this.btn_fonayarla.UseVisualStyleBackColor = true;
            this.btn_fonayarla.Click += new System.EventHandler(this.btn_fonayarla_Click);
            // 
            // btn_renkayarla
            // 
            this.btn_renkayarla.Location = new System.Drawing.Point(158, 194);
            this.btn_renkayarla.Name = "btn_renkayarla";
            this.btn_renkayarla.Size = new System.Drawing.Size(75, 23);
            this.btn_renkayarla.TabIndex = 3;
            this.btn_renkayarla.Text = "Renk Ayarla";
            this.btn_renkayarla.UseVisualStyleBackColor = true;
            this.btn_renkayarla.Click += new System.EventHandler(this.btn_renkayarla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(49, 286);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(139, 286);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder.TabIndex = 5;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(100, 109);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(125, 57);
            this.txt_aciklama.TabIndex = 6;
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(100, 57);
            this.txt_adi.Multiline = true;
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(125, 20);
            this.txt_adi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "Önemli Not!\r\nHedef Form üzerindeki bütün \r\nkontrollerdeki modifier özelliği \r\npub" +
    "lic yaptık";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btn_renkayarla);
            this.Controls.Add(this.btn_fonayarla);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.label1);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.Button btn_fonayarla;
        private System.Windows.Forms.Button btn_renkayarla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

