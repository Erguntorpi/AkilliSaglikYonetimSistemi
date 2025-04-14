namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            groupBox1 = new GroupBox();
            lblAdSoyad = new Label();
            label3 = new Label();
            lblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rchSikayet = new RichTextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            btnCıkıs = new Button();
            btnDuyurular = new Button();
            btnGuncelle = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(26, 188, 156);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(2, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgi";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Calibri", 13.8F);
            lblAdSoyad.Location = new Point(120, 90);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(91, 28);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 90);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad :";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Calibri", 13.8F);
            lblTC.Location = new Point(119, 49);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(144, 28);
            lblTC.TabIndex = 1;
            lblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "T.C. NO :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rchSikayet);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(2, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // rchSikayet
            // 
            rchSikayet.Location = new Point(0, 25);
            rchSikayet.Name = "rchSikayet";
            rchSikayet.Size = new Size(376, 180);
            rchSikayet.TabIndex = 5;
            rchSikayet.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 88);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(26, 188, 156);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(384, 70);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 483);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(39, 174, 96);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(590, 448);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCıkıs);
            groupBox4.Controls.Add(btnDuyurular);
            groupBox4.Controls.Add(btnGuncelle);
            groupBox4.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(8, 425);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(370, 128);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // btnCıkıs
            // 
            btnCıkıs.Location = new Point(20, 75);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(338, 34);
            btnCıkıs.TabIndex = 2;
            btnCıkıs.Text = "Çıkış";
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // btnDuyurular
            // 
            btnDuyurular.Location = new Point(192, 35);
            btnDuyurular.Name = "btnDuyurular";
            btnDuyurular.Size = new Size(166, 34);
            btnDuyurular.TabIndex = 1;
            btnDuyurular.Text = "Duyurular";
            btnDuyurular.UseVisualStyleBackColor = true;
            btnDuyurular.Click += btnDuyurular_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(20, 35);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(166, 34);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Bilgi Düzenle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 34);
            panel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(946, 1);
            button1.Name = "button1";
            button1.Size = new Size(31, 31);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(46, 6);
            label4.Name = "label4";
            label4.Size = new Size(177, 24);
            label4.TabIndex = 0;
            label4.Text = "Doktor Profil Ekranı";
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(980, 560);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmDoktorDetay";
            Text = "Doktor Detay Paneli";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private Label label3;
        private Label lblTC;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox rchSikayet;
        private Label label6;
        private GroupBox groupBox4;
        private Button btnCıkıs;
        private Button btnDuyurular;
        private Button btnGuncelle;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
    }
}