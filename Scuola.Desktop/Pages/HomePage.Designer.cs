namespace Scuola.Desktop
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            panel1 = new Panel();
            picMonitoraggio = new PictureBox();
            picCorsi = new PictureBox();
            picData = new PictureBox();
            picDashboard = new PictureBox();
            btnMini = new Button();
            btnClose = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            lblGiurni = new Label();
            lblDD = new Label();
            lblMM = new Label();
            lblYYYY = new Label();
            panel3 = new Panel();
            btnBackground = new Button();
            analogClock1 = new AnalogClock.AnalogClock();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMonitoraggio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCorsi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(picMonitoraggio);
            panel1.Controls.Add(picCorsi);
            panel1.Controls.Add(picData);
            panel1.Controls.Add(picDashboard);
            panel1.Controls.Add(btnMini);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(180, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 75);
            panel1.TabIndex = 0;
            // 
            // picMonitoraggio
            // 
            picMonitoraggio.Image = (Image)resources.GetObject("picMonitoraggio.Image");
            picMonitoraggio.Location = new Point(263, 7);
            picMonitoraggio.Name = "picMonitoraggio";
            picMonitoraggio.Size = new Size(64, 64);
            picMonitoraggio.SizeMode = PictureBoxSizeMode.AutoSize;
            picMonitoraggio.TabIndex = 7;
            picMonitoraggio.TabStop = false;
            picMonitoraggio.Click += picMonitoraggio_Click;
            // 
            // picCorsi
            // 
            picCorsi.Image = (Image)resources.GetObject("picCorsi.Image");
            picCorsi.Location = new Point(179, 6);
            picCorsi.Name = "picCorsi";
            picCorsi.Size = new Size(64, 64);
            picCorsi.SizeMode = PictureBoxSizeMode.AutoSize;
            picCorsi.TabIndex = 6;
            picCorsi.TabStop = false;
            picCorsi.Click += picCorsi_Click;
            // 
            // picData
            // 
            picData.Image = (Image)resources.GetObject("picData.Image");
            picData.Location = new Point(95, 7);
            picData.Name = "picData";
            picData.Size = new Size(64, 64);
            picData.SizeMode = PictureBoxSizeMode.AutoSize;
            picData.TabIndex = 5;
            picData.TabStop = false;
            picData.Click += picData_Click;
            // 
            // picDashboard
            // 
            picDashboard.Image = (Image)resources.GetObject("picDashboard.Image");
            picDashboard.Location = new Point(11, 7);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(64, 64);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 4;
            picDashboard.TabStop = false;
            picDashboard.Click += picDashboard_Click;
            // 
            // btnMini
            // 
            btnMini.BackColor = Color.Transparent;
            btnMini.BackgroundImage = (Image)resources.GetObject("btnMini.BackgroundImage");
            btnMini.BackgroundImageLayout = ImageLayout.Zoom;
            btnMini.Cursor = Cursors.Hand;
            btnMini.Font = new Font("Arial Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMini.ForeColor = Color.White;
            btnMini.Location = new Point(775, 3);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(30, 30);
            btnMini.TabIndex = 3;
            btnMini.UseVisualStyleBackColor = false;
            btnMini.Click += btnMini_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Arial Nova", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(809, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(871, 7);
            button2.Name = "button2";
            button2.Size = new Size(27, 20);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(904, 6);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(analogClock1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 768);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(lblGiurni);
            panel4.Controls.Add(lblDD);
            panel4.Controls.Add(lblMM);
            panel4.Controls.Add(lblYYYY);
            panel4.Location = new Point(9, 204);
            panel4.Name = "panel4";
            panel4.Size = new Size(165, 186);
            panel4.TabIndex = 0;
            // 
            // lblGiurni
            // 
            lblGiurni.BackColor = Color.Transparent;
            lblGiurni.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGiurni.ForeColor = Color.Black;
            lblGiurni.Location = new Point(3, 134);
            lblGiurni.Name = "lblGiurni";
            lblGiurni.Size = new Size(159, 29);
            lblGiurni.TabIndex = 3;
            lblGiurni.Text = "Lunedi";
            lblGiurni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDD
            // 
            lblDD.BackColor = Color.Transparent;
            lblDD.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDD.ForeColor = Color.Black;
            lblDD.Location = new Point(3, 89);
            lblDD.Name = "lblDD";
            lblDD.Size = new Size(159, 45);
            lblDD.TabIndex = 2;
            lblDD.Text = "13";
            lblDD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMM
            // 
            lblMM.AutoSize = true;
            lblMM.BackColor = Color.Transparent;
            lblMM.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMM.ForeColor = Color.White;
            lblMM.Location = new Point(105, 47);
            lblMM.Name = "lblMM";
            lblMM.Size = new Size(33, 20);
            lblMM.TabIndex = 1;
            lblMM.Text = "Ott";
            // 
            // lblYYYY
            // 
            lblYYYY.AutoSize = true;
            lblYYYY.BackColor = Color.Transparent;
            lblYYYY.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblYYYY.ForeColor = Color.White;
            lblYYYY.Location = new Point(14, 47);
            lblYYYY.Name = "lblYYYY";
            lblYYYY.Size = new Size(45, 20);
            lblYYYY.TabIndex = 0;
            lblYYYY.Text = "2025";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(btnBackground);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(180, 731);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 37);
            panel3.TabIndex = 4;
            // 
            // btnBackground
            // 
            btnBackground.BackColor = Color.FromArgb(128, 128, 255);
            btnBackground.Cursor = Cursors.Hand;
            btnBackground.Image = (Image)resources.GetObject("btnBackground.Image");
            btnBackground.Location = new Point(714, 6);
            btnBackground.Name = "btnBackground";
            btnBackground.Size = new Size(125, 31);
            btnBackground.TabIndex = 0;
            btnBackground.Text = "Background";
            btnBackground.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBackground.UseVisualStyleBackColor = false;
            btnBackground.Click += btnBackground_Click;
            // 
            // analogClock1
            // 
            analogClock1.DrawHourHand = true;
            analogClock1.DrawHourHandShadow = true;
            analogClock1.DrawMinuteHand = true;
            analogClock1.DrawMinuteHandShadow = true;
            analogClock1.DrawSecondHand = true;
            analogClock1.DropShadowColor = Color.Black;
            analogClock1.DropShadowOffset = new Point(0, 0);
            analogClock1.FaceColorHigh = Color.RoyalBlue;
            analogClock1.FaceColorLow = Color.SkyBlue;
            analogClock1.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            analogClock1.FaceImage = null;
            analogClock1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            analogClock1.HourHandColor = Color.Gainsboro;
            analogClock1.HourHandDropShadowColor = Color.Gray;
            analogClock1.Location = new Point(3, 3);
            analogClock1.MinuteHandColor = Color.WhiteSmoke;
            analogClock1.MinuteHandDropShadowColor = Color.Gray;
            analogClock1.MinuteHandTickStyle = AnalogClock.TickStyle.Normal;
            analogClock1.Name = "analogClock1";
            analogClock1.NumeralColor = Color.WhiteSmoke;
            analogClock1.RimColorHigh = Color.RoyalBlue;
            analogClock1.RimColorLow = Color.SkyBlue;
            analogClock1.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            analogClock1.SecondHandColor = Color.Tomato;
            analogClock1.SecondHandDropShadowColor = Color.Gray;
            analogClock1.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Round;
            analogClock1.SecondHandTickStyle = AnalogClock.TickStyle.Normal;
            analogClock1.Size = new Size(176, 176);
            analogClock1.TabIndex = 1;
            analogClock1.Time = new DateTime(0L);
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1024, 768);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1024, 768);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMonitoraggio).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCorsi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picData).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button btnClose;
        private Button btnMini;
        private PictureBox picMonitoraggio;
        private PictureBox picCorsi;
        private PictureBox picData;
        private PictureBox picDashboard;
        private Button btnBackground;
        private Panel panel4;
        private Label lblYYYY;
        private Label lblMM;
        private Label lblGiurni;
        private Label lblDD;
        private AnalogClock.AnalogClock analogClock1;
    }
}