namespace Proje_Hastane
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            txtSoyad = new TextBox();
            label3 = new Label();
            mskTc = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            mskTelefon = new MaskedTextBox();
            cmbCınsıyet = new ComboBox();
            label6 = new Label();
            btnKayıt = new Button();
            txtSifre = new TextBox();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(188, 134);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(232, 36);
            txtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label3.Location = new Point(132, 97);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 7;
            label3.Text = "Ad :";
            // 
            // mskTc
            // 
            mskTc.Location = new Point(188, 177);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(233, 36);
            mskTc.TabIndex = 3;
            mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label2.Location = new Point(33, 181);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 5;
            label2.Text = " TC Kimlik No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label1.Location = new Point(101, 139);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 9;
            label1.Text = "Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label4.Location = new Point(88, 224);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 10;
            label4.Text = "Telefon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label5.Location = new Point(114, 310);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 11;
            label5.Text = "Şifre :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(187, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(233, 36);
            txtAd.TabIndex = 1;
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(187, 220);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(235, 36);
            mskTelefon.TabIndex = 4;
            // 
            // cmbCınsıyet
            // 
            cmbCınsıyet.FormattingEnabled = true;
            cmbCınsıyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCınsıyet.Location = new Point(187, 263);
            cmbCınsıyet.Name = "cmbCınsıyet";
            cmbCınsıyet.Size = new Size(235, 36);
            cmbCınsıyet.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label6.Location = new Point(82, 268);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 15;
            label6.Text = "Cinsiyet :";
            // 
            // btnKayıt
            // 
            btnKayıt.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayıt.Location = new Point(241, 368);
            btnKayıt.Name = "btnKayıt";
            btnKayıt.Size = new Size(111, 40);
            btnKayıt.TabIndex = 16;
            btnKayıt.Text = "Kayıt Yap";
            btnKayıt.UseVisualStyleBackColor = true;
            btnKayıt.Click += btnKayıt_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(189, 305);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(233, 36);
            txtSifre.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 34);
            panel1.TabIndex = 17;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(478, 0);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(31, 31);
            btnCıkıs.TabIndex = 7;
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(46, 6);
            label7.Name = "label7";
            label7.Size = new Size(163, 24);
            label7.TabIndex = 0;
            label7.Text = "Hasta Kayıt Ekranı";
            // 
            // FrmHastaKayıt
            // 
            AcceptButton = btnKayıt;
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(510, 491);
            Controls.Add(panel1);
            Controls.Add(txtSifre);
            Controls.Add(btnKayıt);
            Controls.Add(label6);
            Controls.Add(cmbCınsıyet);
            Controls.Add(mskTelefon);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(mskTc);
            Controls.Add(label2);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmHastaKayıt";
            Text = "Hasta Kayıt";
            Load += FrmHastaKayıt_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyad;
        private Label label3;
        private MaskedTextBox mskTc;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private MaskedTextBox mskTelefon;
        private ComboBox cmbCınsıyet;
        private Label label6;
        private Button btnKayıt;
        private TextBox txtSifre;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
        private Button btnCıkıs;
    }
}