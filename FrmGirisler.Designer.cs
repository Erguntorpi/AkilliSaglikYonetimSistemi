namespace Proje_Hastane
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            btnHastaGirisi = new Button();
            btnDoktorGirisi = new Button();
            btnSekreterGirisi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnHastaGirisi
            // 
            btnHastaGirisi.BackgroundImage = (Image)resources.GetObject("btnHastaGirisi.BackgroundImage");
            btnHastaGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            btnHastaGirisi.Location = new Point(48, 234);
            btnHastaGirisi.Name = "btnHastaGirisi";
            btnHastaGirisi.Size = new Size(242, 155);
            btnHastaGirisi.TabIndex = 0;
            btnHastaGirisi.UseVisualStyleBackColor = true;
            btnHastaGirisi.Click += btnHastaGirisi_Click;
            // 
            // btnDoktorGirisi
            // 
            btnDoktorGirisi.BackgroundImage = (Image)resources.GetObject("btnDoktorGirisi.BackgroundImage");
            btnDoktorGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            btnDoktorGirisi.Location = new Point(330, 234);
            btnDoktorGirisi.Name = "btnDoktorGirisi";
            btnDoktorGirisi.Size = new Size(242, 155);
            btnDoktorGirisi.TabIndex = 1;
            btnDoktorGirisi.UseVisualStyleBackColor = true;
            btnDoktorGirisi.Click += btnDoktorGirisi_Click;
            // 
            // btnSekreterGirisi
            // 
            btnSekreterGirisi.BackgroundImage = (Image)resources.GetObject("btnSekreterGirisi.BackgroundImage");
            btnSekreterGirisi.BackgroundImageLayout = ImageLayout.Stretch;
            btnSekreterGirisi.Location = new Point(612, 234);
            btnSekreterGirisi.Name = "btnSekreterGirisi";
            btnSekreterGirisi.Size = new Size(242, 155);
            btnSekreterGirisi.TabIndex = 2;
            btnSekreterGirisi.UseVisualStyleBackColor = true;
            btnSekreterGirisi.Click += btnSekreterGirisi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(131, 406);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 3;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(406, 406);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 4;
            label2.Text = "Doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(687, 406);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 5;
            label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(662, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(32, 90);
            label4.Name = "label4";
            label4.Size = new Size(605, 71);
            label4.TabIndex = 7;
            label4.Text = "Akıllı Sağlık Yönetim Sistemi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 34);
            panel1.TabIndex = 17;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(886, 1);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(31, 31);
            btnCıkıs.TabIndex = 7;
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(51, 6);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 0;
            label5.Text = "ASYS Giriş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(705, 476);
            label6.Name = "label6";
            label6.Size = new Size(207, 21);
            label6.TabIndex = 18;
            label6.Text = "Akıllı Sağlık Yönetim Sistemi";
            // 
            // FrmGirisler
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.IndianRed;
            ClientSize = new Size(916, 501);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSekreterGirisi);
            Controls.Add(btnDoktorGirisi);
            Controls.Add(btnHastaGirisi);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmGirisler";
            Text = "Randevu Hub";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHastaGirisi;
        private Button btnDoktorGirisi;
        private Button btnSekreterGirisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label5;
        private Button btnCıkıs;
        private Label label6;
    }
}
