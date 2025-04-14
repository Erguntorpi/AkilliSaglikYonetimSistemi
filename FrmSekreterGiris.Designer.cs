namespace Proje_Hastane
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            btnGiris = new Button();
            txtSıfre = new TextBox();
            label3 = new Label();
            mskTc = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(395, 322);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(111, 40);
            btnGiris.TabIndex = 13;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSıfre
            // 
            txtSıfre.Font = new Font("Calibri", 13.8F);
            txtSıfre.Location = new Point(337, 259);
            txtSıfre.Name = "txtSıfre";
            txtSıfre.Size = new Size(233, 36);
            txtSıfre.TabIndex = 11;
            txtSıfre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label3.Location = new Point(264, 267);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 10;
            label3.Text = "Şifre :";
            // 
            // mskTc
            // 
            mskTc.Font = new Font("Calibri", 13.8F);
            mskTc.Location = new Point(337, 197);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(233, 36);
            mskTc.TabIndex = 9;
            mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
            label2.Location = new Point(183, 204);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 8;
            label2.Text = " TC Kimlik No :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(115, 97);
            label1.Name = "label1";
            label1.Size = new Size(534, 73);
            label1.TabIndex = 7;
            label1.Text = "Sekreter Giriş Ekranı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 34);
            panel1.TabIndex = 14;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(718, 1);
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
            label4.Location = new Point(44, 6);
            label4.Name = "label4";
            label4.Size = new Size(204, 24);
            label4.TabIndex = 0;
            label4.Text = "Sekreter Kullanıcı Girişi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(537, 465);
            label5.Name = "label5";
            label5.Size = new Size(207, 21);
            label5.TabIndex = 15;
            label5.Text = "Akıllı Sağlık Yönetim Sistemi";
            // 
            // FrmSekreterGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(26, 188, 156);
            ClientSize = new Size(750, 489);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnGiris);
            Controls.Add(txtSıfre);
            Controls.Add(label3);
            Controls.Add(mskTc);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmSekreterGiris";
            Text = "Sekreter Girişi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private TextBox txtSıfre;
        private Label label3;
        private MaskedTextBox mskTc;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnCıkıs;
        private Label label5;
    }
}