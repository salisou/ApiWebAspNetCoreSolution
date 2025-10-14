namespace Scuola.Desktop.EsempiForms
{
    partial class ProgressBarControlEsempio
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 30);
            label1.TabIndex = 0;
            label1.Text = "Caricamento del CRM Scuola";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(13, 42);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(376, 31);
            progressBar1.TabIndex = 1;
            // 
            // ProgressBarControlEsempio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 91);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProgressBarControlEsempio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressBarControlEsempio";
            Load += ProgressBarControlEsempio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}