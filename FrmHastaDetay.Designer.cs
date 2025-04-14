namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            groupBox1 = new GroupBox();
            lblAdSoyad = new Label();
            label2 = new Label();
            lblTc = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtId = new TextBox();
            label1 = new Label();
            lnkBilgiDüzenle = new LinkLabel();
            btnRandevuAl = new Button();
            label7 = new Label();
            label6 = new Label();
            rchSikayet = new RichTextBox();
            cmbDoctor = new ComboBox();
            label5 = new Label();
            cmbBranş = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTc);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(2, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAdSoyad.Location = new Point(118, 111);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(96, 28);
            lblAdSoyad.TabIndex = 8;
            lblAdSoyad.Text = "Null Null ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label2.Location = new Point(10, 111);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 8;
            label2.Text = "Ad Soyad :";
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTc.Location = new Point(118, 58);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(144, 28);
            lblTc.TabIndex = 8;
            lblTc.Text = "00000000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label3.Location = new Point(40, 58);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 8;
            label3.Text = "TC NO :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lnkBilgiDüzenle);
            groupBox2.Controls.Add(btnRandevuAl);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(rchSikayet);
            groupBox2.Controls.Add(cmbDoctor);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbBranş);
            groupBox2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(2, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 389);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(101, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(211, 36);
            txtId.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label1.Location = new Point(53, 44);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            // 
            // lnkBilgiDüzenle
            // 
            lnkBilgiDüzenle.AutoSize = true;
            lnkBilgiDüzenle.Location = new Point(0, 358);
            lnkBilgiDüzenle.Name = "lnkBilgiDüzenle";
            lnkBilgiDüzenle.Size = new Size(169, 28);
            lnkBilgiDüzenle.TabIndex = 7;
            lnkBilgiDüzenle.TabStop = true;
            lnkBilgiDüzenle.Text = "Bilgileri Düzenle";
            lnkBilgiDüzenle.LinkClicked += lnkBilgiDüzenle_LinkClicked;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRandevuAl.Location = new Point(118, 306);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(157, 48);
            btnRandevuAl.TabIndex = 5;
            btnRandevuAl.Text = "Randevu Al";
            btnRandevuAl.UseVisualStyleBackColor = true;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label7.Location = new Point(1, 180);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 6;
            label7.Text = "Şikayet :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label6.Location = new Point(5, 137);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 5;
            label6.Text = "Doktor :";
            // 
            // rchSikayet
            // 
            rchSikayet.Location = new Point(101, 180);
            rchSikayet.Name = "rchSikayet";
            rchSikayet.Size = new Size(211, 120);
            rchSikayet.TabIndex = 4;
            rchSikayet.Text = "";
            // 
            // cmbDoctor
            // 
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(101, 134);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(211, 36);
            cmbDoctor.TabIndex = 4;
            cmbDoctor.SelectedIndexChanged += cmbDoctor_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label5.Location = new Point(19, 91);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 3;
            label5.Text = "Branş :";
            // 
            // cmbBranş
            // 
            cmbBranş.FormattingEnabled = true;
            cmbBranş.Location = new Point(101, 87);
            cmbBranş.Name = "cmbBranş";
            cmbBranş.Size = new Size(211, 36);
            cmbBranş.TabIndex = 2;
            cmbBranş.SelectedIndexChanged += cmbBranş_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(26, 188, 156);
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(328, 36);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(870, 270);
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
            dataGridView1.Size = new Size(864, 235);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(328, 312);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(870, 283);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(39, 174, 96);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(864, 248);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 34);
            panel1.TabIndex = 16;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(1164, 1);
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
            label4.Location = new Point(49, 7);
            label4.Name = "label4";
            label4.Size = new Size(166, 24);
            label4.TabIndex = 0;
            label4.Text = "Hasta Profil Ekranı";
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(1200, 594);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmHastaDetay";
            Text = "Hasta Detay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private Label label2;
        private Label lblTc;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnRandevuAl;
        private Label label7;
        private Label label6;
        private RichTextBox rchSikayet;
        private ComboBox cmbDoctor;
        private Label label5;
        private ComboBox cmbBranş;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel lnkBilgiDüzenle;
        private TextBox txtId;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnCıkıs;
    }
}