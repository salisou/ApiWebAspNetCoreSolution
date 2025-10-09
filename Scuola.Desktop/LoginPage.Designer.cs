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
            lblNome = new Label();
            txtNomeUtente = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 37);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(99, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome dell'utente";
            // 
            // txtNomeUtente
            // 
            txtNomeUtente.Location = new Point(27, 55);
            txtNomeUtente.Name = "txtNomeUtente";
            txtNomeUtente.Size = new Size(345, 23);
            txtNomeUtente.TabIndex = 1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNomeUtente);
            Controls.Add(lblNome);
            Name = "LoginPage";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNomeUtente;
    }
}