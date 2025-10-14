namespace Scuola.Desktop.EsempiForms
{
    partial class ComboBoxEsempio
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(28, 86);
            button1.Name = "button1";
            button1.Size = new Size(142, 31);
            button1.TabIndex = 1;
            button1.Text = "Display Select Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 2;
            label1.Text = "Name of Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(564, 24);
            label2.Name = "label2";
            label2.Size = new Size(134, 30);
            label2.TabIndex = 3;
            label2.Text = "Enter Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(532, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(559, 87);
            button2.Name = "button2";
            button2.Size = new Size(117, 30);
            button2.TabIndex = 5;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ComboBoxEsempio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "ComboBoxEsempio";
            Text = "ComboBoxEsempio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
    }
}