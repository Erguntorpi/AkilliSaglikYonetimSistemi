namespace Proje_Hastane
{
    partial class FrmAydınlatmaMetni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAydınlatmaMetni));
            panel1 = new Panel();
            btnCıkıs = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnCıkıs);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 34);
            panel1.TabIndex = 0;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackgroundImage = (Image)resources.GetObject("btnCıkıs.BackgroundImage");
            btnCıkıs.BackgroundImageLayout = ImageLayout.Zoom;
            btnCıkıs.Location = new Point(821, 1);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(31, 31);
            btnCıkıs.TabIndex = 8;
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(45, 5);
            label1.Name = "label1";
            label1.Size = new Size(160, 24);
            label1.TabIndex = 0;
            label1.Text = "Aydınlatma Metni";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(792, 342);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(647, 438);
            label4.Name = "label4";
            label4.Size = new Size(207, 21);
            label4.TabIndex = 4;
            label4.Text = "Akıllı Sağlık Yönetim Sistemi";
            // 
            // FrmAydınlatmaMetni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(857, 462);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAydınlatmaMetni";
            Text = "FrmAydınlatmaMetni";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCıkıs;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}