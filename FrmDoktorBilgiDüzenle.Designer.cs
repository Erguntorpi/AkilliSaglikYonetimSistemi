namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            txtAd = new TextBox();
            label1 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            mskTc = new MaskedTextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label5 = new Label();
            cmbBrans = new ComboBox();
            label4 = new Label();
            btnBilgiGuncelle = new Button();
            panel1 = new Panel();
            btnCıkıs = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Calibri", 13.8F);
            txtAd.Location = new Point(173, 87);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 36);
            txtAd.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label1.Location = new Point(87, 135);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 30;
            label1.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Calibri", 13.8F);
            txtSoyad.Location = new Point(173, 131);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 36);
            txtSoyad.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label3.Location = new Point(118, 90);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 28;
            label3.Text = "Ad :";
            // 
            // mskTc
            // 
            mskTc.Font = new Font("Calibri", 13.8F);
            mskTc.Location = new Point(174, 176);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(250, 36);
            mskTc.TabIndex = 27;
            mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label2.Location = new Point(19, 180);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 26;
            label2.Text = " TC Kimlik No :";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Calibri", 13.8F);
            txtSifre.Location = new Point(174, 271);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(250, 36);
            txtSifre.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label5.Location = new Point(100, 274);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 32;
            label5.Text = "Şifre :";
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Calibri", 13.8F);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(173, 220);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(251, 36);
            cmbBrans.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label4.Location = new Point(92, 224);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 35;
            label4.Text = "Branş :";
            // 
            // btnBilgiGuncelle
            // 
            btnBilgiGuncelle.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBilgiGuncelle.Location = new Point(242, 334);
            btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            btnBilgiGuncelle.Size = new Size(111, 40);
            btnBilgiGuncelle.TabIndex = 36;
            btnBilgiGuncelle.Text = "Güncelle";
            btnBilgiGuncelle.UseVisualStyleBackColor = true;
            btnBilgiGuncelle.Click += btnBilgiGuncelle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 34);
            panel1.TabIndex = 37;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(443, 2);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(31, 31);
            btnCıkıs.TabIndex = 5;
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(37, 6);
            label6.Name = "label6";
            label6.Size = new Size(271, 24);
            label6.TabIndex = 1;
            label6.Text = "Doktor Bilgi Güncelleme Ekranı";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmDoktorBilgiDüzenle
            // 
            AcceptButton = btnBilgiGuncelle;
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(477, 464);
            Controls.Add(panel1);
            Controls.Add(btnBilgiGuncelle);
            Controls.Add(label4);
            Controls.Add(cmbBrans);
            Controls.Add(txtSifre);
            Controls.Add(label5);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(mskTc);
            Controls.Add(label2);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmDoktorBilgiDüzenle";
            Text = "Doktor Bilgi Güncelleme Paneli";
            Load += FrmDoktorBilgiDüzenle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label1;
        private TextBox txtSoyad;
        private Label label3;
        private MaskedTextBox mskTc;
        private Label label2;
        private TextBox txtSifre;
        private Label label5;
        private ComboBox cmbBrans;
        private Label label4;
        private Button btnBilgiGuncelle;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnCıkıs;
    }
}