namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            groupBox1 = new GroupBox();
            lblTc = new Label();
            lblAdSoyad = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDuyuruOluştur = new Button();
            rchDuyuru = new RichTextBox();
            groupBox3 = new GroupBox();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            chkDurum = new CheckBox();
            mskTc = new MaskedTextBox();
            cmbDoktor = new ComboBox();
            cmbBrans = new ComboBox();
            mskSaat = new MaskedTextBox();
            mskTarıh = new MaskedTextBox();
            txtId = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            btnDuyurular = new Button();
            btnBransPanel = new Button();
            btnDoktorPanel = new Button();
            btnListele = new Button();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(lblTc);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(0, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Calibri", 13.8F);
            lblTc.Location = new Point(144, 50);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(156, 28);
            lblTc.TabIndex = 3;
            lblTc.Text = "000000000000";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Calibri", 13.8F);
            lblAdSoyad.Location = new Point(144, 86);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(91, 28);
            lblAdSoyad.TabIndex = 2;
            lblAdSoyad.Text = "Null Null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "T.C. NO :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(btnDuyuruOluştur);
            groupBox2.Controls.Add(rchDuyuru);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(0, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 291);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Bildir";
            // 
            // btnDuyuruOluştur
            // 
            btnDuyuruOluştur.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDuyuruOluştur.Location = new Point(80, 206);
            btnDuyuruOluştur.Name = "btnDuyuruOluştur";
            btnDuyuruOluştur.Size = new Size(127, 38);
            btnDuyuruOluştur.TabIndex = 1;
            btnDuyuruOluştur.Text = "Oluştur";
            btnDuyuruOluştur.UseVisualStyleBackColor = true;
            btnDuyuruOluştur.Click += btnDuyuruOluştur_Click;
            // 
            // rchDuyuru
            // 
            rchDuyuru.Location = new Point(6, 43);
            rchDuyuru.Name = "rchDuyuru";
            rchDuyuru.Size = new Size(282, 141);
            rchDuyuru.TabIndex = 0;
            rchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 255, 192);
            groupBox3.Controls.Add(btnGuncelle);
            groupBox3.Controls.Add(btnKaydet);
            groupBox3.Controls.Add(chkDurum);
            groupBox3.Controls.Add(mskTc);
            groupBox3.Controls.Add(cmbDoktor);
            groupBox3.Controls.Add(cmbBrans);
            groupBox3.Controls.Add(mskSaat);
            groupBox3.Controls.Add(mskTarıh);
            groupBox3.Controls.Add(txtId);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(294, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 437);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnGuncelle.Location = new Point(31, 352);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(127, 38);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnKaydet.Location = new Point(185, 352);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(127, 38);
            btnKaydet.TabIndex = 14;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // chkDurum
            // 
            chkDurum.AutoSize = true;
            chkDurum.Font = new Font("Calibri", 13.8F);
            chkDurum.Location = new Point(100, 272);
            chkDurum.Name = "chkDurum";
            chkDurum.Size = new Size(98, 32);
            chkDurum.TabIndex = 13;
            chkDurum.Text = "Durum";
            chkDurum.UseVisualStyleBackColor = true;
            // 
            // mskTc
            // 
            mskTc.Font = new Font("Calibri", 13.8F);
            mskTc.Location = new Point(101, 230);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(211, 36);
            mskTc.TabIndex = 12;
            mskTc.ValidatingType = typeof(int);
            // 
            // cmbDoktor
            // 
            cmbDoktor.Font = new Font("Calibri", 13.8F);
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(100, 191);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(211, 36);
            cmbDoktor.TabIndex = 11;
            // 
            // cmbBrans
            // 
            cmbBrans.Font = new Font("Calibri", 13.8F);
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(100, 151);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(212, 36);
            cmbBrans.TabIndex = 10;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // mskSaat
            // 
            mskSaat.Font = new Font("Calibri", 13.8F);
            mskSaat.Location = new Point(100, 112);
            mskSaat.Mask = "00:00";
            mskSaat.Name = "mskSaat";
            mskSaat.Size = new Size(211, 36);
            mskSaat.TabIndex = 9;
            mskSaat.ValidatingType = typeof(DateTime);
            // 
            // mskTarıh
            // 
            mskTarıh.Font = new Font("Calibri", 13.8F);
            mskTarıh.Location = new Point(100, 73);
            mskTarıh.Mask = "00/00/0000";
            mskTarıh.Name = "mskTarıh";
            mskTarıh.Size = new Size(211, 36);
            mskTarıh.TabIndex = 8;
            mskTarıh.ValidatingType = typeof(DateTime);
            // 
            // txtId
            // 
            txtId.Font = new Font("Calibri", 13.8F);
            txtId.Location = new Point(100, 33);
            txtId.Name = "txtId";
            txtId.Size = new Size(212, 36);
            txtId.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label10.Location = new Point(47, 234);
            label10.Name = "label10";
            label10.Size = new Size(45, 28);
            label10.TabIndex = 5;
            label10.Text = "TC :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label9.Location = new Point(3, 195);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 4;
            label9.Text = "Doktor :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label8.Location = new Point(17, 154);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 3;
            label8.Text = "Branş :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label7.Location = new Point(28, 116);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 2;
            label7.Text = "Saat :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label6.Location = new Point(23, 78);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 1;
            label6.Text = "Tarih :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label5.Location = new Point(51, 38);
            label5.Name = "label5";
            label5.Size = new Size(41, 28);
            label5.TabIndex = 0;
            label5.Text = "Id :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(611, 34);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(585, 273);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(39, 174, 96);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 242);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.Location = new Point(612, 307);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(584, 287);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(39, 174, 96);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(578, 256);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(255, 255, 192);
            groupBox6.Controls.Add(btnDuyurular);
            groupBox6.Controls.Add(btnBransPanel);
            groupBox6.Controls.Add(btnDoktorPanel);
            groupBox6.Controls.Add(btnListele);
            groupBox6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.Location = new Point(0, 471);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(613, 123);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hızlı Erişim";
            // 
            // btnDuyurular
            // 
            btnDuyurular.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnDuyurular.Location = new Point(57, 75);
            btnDuyurular.Name = "btnDuyurular";
            btnDuyurular.Size = new Size(225, 38);
            btnDuyurular.TabIndex = 19;
            btnDuyurular.Text = "Duyurular";
            btnDuyurular.UseVisualStyleBackColor = true;
            btnDuyurular.Click += btnDuyurular_Click;
            // 
            // btnBransPanel
            // 
            btnBransPanel.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnBransPanel.Location = new Point(352, 30);
            btnBransPanel.Name = "btnBransPanel";
            btnBransPanel.Size = new Size(225, 38);
            btnBransPanel.TabIndex = 17;
            btnBransPanel.Text = "Branş Güncelleme";
            btnBransPanel.UseVisualStyleBackColor = true;
            btnBransPanel.Click += btnBransPanel_Click;
            // 
            // btnDoktorPanel
            // 
            btnDoktorPanel.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnDoktorPanel.Location = new Point(57, 31);
            btnDoktorPanel.Name = "btnDoktorPanel";
            btnDoktorPanel.Size = new Size(225, 38);
            btnDoktorPanel.TabIndex = 16;
            btnDoktorPanel.Text = "Doktor Kayıt";
            btnDoktorPanel.UseVisualStyleBackColor = true;
            btnDoktorPanel.Click += btnDoktorPanel_Click_1;
            // 
            // btnListele
            // 
            btnListele.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            btnListele.Location = new Point(352, 74);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(225, 38);
            btnListele.TabIndex = 18;
            btnListele.Text = "Randevu Listesi";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 34);
            panel1.TabIndex = 15;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(1169, 1);
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
            pictureBox1.Size = new Size(57, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(48, 6);
            label4.Name = "label4";
            label4.Size = new Size(188, 24);
            label4.TabIndex = 0;
            label4.Text = "Sekreter Profil Ekranı";
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(1204, 594);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            Text = "Sekreter Detay";
            Load += FrmSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTc;
        private Label lblAdSoyad;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnDuyuruOluştur;
        private RichTextBox rchDuyuru;
        private GroupBox groupBox3;
        private CheckBox chkDurum;
        private MaskedTextBox mskTc;
        private ComboBox cmbDoktor;
        private ComboBox cmbBrans;
        private MaskedTextBox mskSaat;
        private MaskedTextBox mskTarıh;
        private TextBox txtId;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnGuncelle;
        private Button btnKaydet;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button btnListele;
        private Button btnBransPanel;
        private Button btnDoktorPanel;
        private Button btnDuyurular;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnCıkıs;
    }
}