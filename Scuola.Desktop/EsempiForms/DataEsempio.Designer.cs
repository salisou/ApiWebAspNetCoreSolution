namespace Scuola.Desktop.EsempiForms
{
    partial class DataEsempio
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
            lblResult = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.ActiveCaption;
            lblResult.Location = new Point(223, 19);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(390, 30);
            lblResult.TabIndex = 0;
            lblResult.Text = "../../....";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Select Data";
            // 
            // button1
            // 
            button1.Location = new Point(10, 56);
            button1.Name = "button1";
            button1.Size = new Size(103, 33);
            button1.TabIndex = 3;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DataEsempio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 106);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblResult);
            Name = "DataEsempio";
            Text = "DataEsempio";
            Load += DataEsempio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button button1;
    }
}