﻿namespace Scuola.Desktop.EsempiForms
{
    partial class ListaBox
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
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 379);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(332, 19);
            button1.Name = "button1";
            button1.Size = new Size(213, 46);
            button1.TabIndex = 1;
            button1.Text = "Display Select Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListaBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 422);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "ListaBox";
            Text = "ListBox";
            Load += ListBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Button button1;
    }
}