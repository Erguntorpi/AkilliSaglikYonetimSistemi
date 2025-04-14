namespace Proje_Hastane
{
    partial class frmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorPaneli));
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbBrans = new ComboBox();
            dataGridView1 = new DataGridView();
            mskTc = new MaskedTextBox();
            txtSifre = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(107, 88);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(186, 36);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(107, 132);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(186, 36);
            txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label1.Location = new Point(46, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 2;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label2.Location = new Point(15, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 3;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label3.Location = new Point(20, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 4;
            label3.Text = "Branş :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label4.Location = new Point(50, 221);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 28);
            label4.TabIndex = 5;
            label4.Text = "TC :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label5.Location = new Point(28, 266);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 6;
            label5.Text = "Şifre :";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(107, 175);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(186, 36);
            cmbBrans.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(39, 174, 96);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(629, 326);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // mskTc
            // 
            mskTc.Location = new Point(106, 218);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(187, 36);
            mskTc.TabIndex = 4;
            mskTc.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(107, 262);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(186, 36);
            txtSifre.TabIndex = 5;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnEkle.Location = new Point(96, 324);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 38);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnSil.Location = new Point(211, 324);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 38);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnGuncelle.Location = new Point(96, 377);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(209, 37);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 34);
            panel1.TabIndex = 17;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(938, 1);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(31, 31);
            btnCıkıs.TabIndex = 7;
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(44, 6);
            label6.Name = "label6";
            label6.Size = new Size(174, 24);
            label6.TabIndex = 0;
            label6.Text = "Doktor Kayıt Ekranı";
            // 
            // frmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(974, 461);
            Controls.Add(panel1);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtSifre);
            Controls.Add(mskTc);
            Controls.Add(dataGridView1);
            Controls.Add(cmbBrans);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmDoktorPaneli";
            Text = "Doktor Paneli";
            Load += frmDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbBrans;
        private DataGridView dataGridView1;
        private MaskedTextBox mskTc;
        private TextBox txtSifre;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnCıkıs;
    }
}