namespace Proje_Hastane
{
    partial class FrmHastaGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiriş));
            label1 = new Label();
            label2 = new Label();
            mskTc = new MaskedTextBox();
            label3 = new Label();
            txtSıfre = new TextBox();
            lnkUyeol = new LinkLabel();
            btnGiris = new Button();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(146, 101);
            label1.Name = "label1";
            label1.Size = new Size(473, 73);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(176, 209);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 1;
            label2.Text = "T.C. Kimlik No :";
            // 
            // mskTc
            // 
            mskTc.Location = new Point(338, 206);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(233, 36);
            mskTc.TabIndex = 2;
            mskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(263, 262);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 3;
            label3.Text = "Şifre :";
            // 
            // txtSıfre
            // 
            txtSıfre.Location = new Point(338, 259);
            txtSıfre.Name = "txtSıfre";
            txtSıfre.Size = new Size(233, 36);
            txtSıfre.TabIndex = 4;
            txtSıfre.UseSystemPasswordChar = true;
            // 
            // lnkUyeol
            // 
            lnkUyeol.AutoSize = true;
            lnkUyeol.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lnkUyeol.Location = new Point(512, 298);
            lnkUyeol.Name = "lnkUyeol";
            lnkUyeol.Size = new Size(59, 22);
            lnkUyeol.TabIndex = 5;
            lnkUyeol.TabStop = true;
            lnkUyeol.Text = "Üye Ol";
            lnkUyeol.LinkClicked += lnkUyeol_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(387, 328);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(111, 40);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 34);
            panel1.TabIndex = 15;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(716, 1);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(44, 5);
            label4.Name = "label4";
            label4.Size = new Size(182, 24);
            label4.TabIndex = 0;
            label4.Text = "Hasta Kullanıcı Girişi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(539, 465);
            label5.Name = "label5";
            label5.Size = new Size(207, 21);
            label5.TabIndex = 16;
            label5.Text = "Akıllı Sağlık Yönetim Sistemi";
            // 
            // FrmHastaGiriş
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(750, 489);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnGiris);
            Controls.Add(lnkUyeol);
            Controls.Add(txtSıfre);
            Controls.Add(label3);
            Controls.Add(mskTc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmHastaGiriş";
            Text = "HastaGiriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox mskTc;
        private Label label3;
        private TextBox txtSıfre;
        private LinkLabel lnkUyeol;
        private Button btnGiris;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnCıkıs;
        private Label label5;
    }
}