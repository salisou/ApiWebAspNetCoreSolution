namespace Scuola.Desktop
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            lblNome = new Label();
            txtNome = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnAccedi = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnRegiter = new Button();
            lblBenvenuto = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnEsci = new Button();
            picPasswordToggle = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPasswordToggle).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(265, 280);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(265, 298);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "inserisci il Nome";
            txtNome.Size = new Size(322, 23);
            txtNome.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(265, 349);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Inserisci la password";
            txtPassword.Size = new Size(290, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(265, 331);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // btnAccedi
            // 
            btnAccedi.BackColor = Color.Lime;
            btnAccedi.ForeColor = Color.White;
            btnAccedi.Location = new Point(296, 387);
            btnAccedi.Name = "btnAccedi";
            btnAccedi.Size = new Size(243, 36);
            btnAccedi.TabIndex = 4;
            btnAccedi.Text = "Accedi";
            btnAccedi.UseVisualStyleBackColor = false;
            btnAccedi.Click += btnAccedi_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegiter);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 435);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(37, 187);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 11;
            label2.Text = "Registrati ora!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 126);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 10;
            label1.Text = "Non sei regitrato? ";
            // 
            // btnRegiter
            // 
            btnRegiter.BackColor = Color.Lime;
            btnRegiter.ForeColor = Color.White;
            btnRegiter.Location = new Point(49, 259);
            btnRegiter.Name = "btnRegiter";
            btnRegiter.Size = new Size(110, 38);
            btnRegiter.TabIndex = 9;
            btnRegiter.Text = "Registrati";
            btnRegiter.UseVisualStyleBackColor = false;
            btnRegiter.Click += btnRegiter_Click;
            // 
            // lblBenvenuto
            // 
            lblBenvenuto.AutoSize = true;
            lblBenvenuto.BackColor = Color.Transparent;
            lblBenvenuto.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBenvenuto.ForeColor = Color.Lime;
            lblBenvenuto.Location = new Point(215, 32);
            lblBenvenuto.Name = "lblBenvenuto";
            lblBenvenuto.Size = new Size(372, 32);
            lblBenvenuto.TabIndex = 0;
            lblBenvenuto.Text = "Benvenuto! Effettua il login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(226, 298);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(226, 349);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // btnEsci
            // 
            btnEsci.BackColor = Color.Red;
            btnEsci.ForeColor = Color.White;
            btnEsci.Image = (Image)resources.GetObject("btnEsci.Image");
            btnEsci.Location = new Point(582, 5);
            btnEsci.Name = "btnEsci";
            btnEsci.Size = new Size(32, 30);
            btnEsci.TabIndex = 11;
            btnEsci.UseVisualStyleBackColor = false;
            btnEsci.Click += btnEsci_Click;
            // 
            // picPasswordToggle
            // 
            picPasswordToggle.Image = (Image)resources.GetObject("picPasswordToggle.Image");
            picPasswordToggle.Location = new Point(554, 349);
            picPasswordToggle.Name = "picPasswordToggle";
            picPasswordToggle.Size = new Size(33, 20);
            picPasswordToggle.SizeMode = PictureBoxSizeMode.Zoom;
            picPasswordToggle.TabIndex = 12;
            picPasswordToggle.TabStop = false;
            picPasswordToggle.Click += picPasswordToggle_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 435);
            Controls.Add(picPasswordToggle);
            Controls.Add(btnEsci);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(lblBenvenuto);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnAccedi);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPasswordToggle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnAccedi;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnRegiter;
        private Label lblBenvenuto;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnEsci;
        private PictureBox picPasswordToggle;
    }
}