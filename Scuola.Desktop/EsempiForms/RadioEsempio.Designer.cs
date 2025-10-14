namespace Scuola.Desktop.EsempiForms
{
    partial class RadioEsempio
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
            label1 = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            rbnF = new RadioButton();
            rbnM = new RadioButton();
            txtCognome = new TextBox();
            label2 = new Label();
            txtEta = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            checkAdin = new CheckBox();
            checkStudent = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(38, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(321, 23);
            txtNome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(38, 296);
            button1.Name = "button1";
            button1.Size = new Size(76, 33);
            button1.TabIndex = 2;
            button1.Text = "Visualizza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbnF
            // 
            rbnF.AutoSize = true;
            rbnF.Location = new Point(38, 224);
            rbnF.Name = "rbnF";
            rbnF.Size = new Size(31, 19);
            rbnF.TabIndex = 3;
            rbnF.TabStop = true;
            rbnF.Text = "F";
            rbnF.UseVisualStyleBackColor = true;
            // 
            // rbnM
            // 
            rbnM.AutoSize = true;
            rbnM.Location = new Point(75, 224);
            rbnM.Name = "rbnM";
            rbnM.Size = new Size(36, 19);
            rbnM.TabIndex = 4;
            rbnM.TabStop = true;
            rbnM.Text = "M";
            rbnM.UseVisualStyleBackColor = true;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(38, 91);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(321, 23);
            txtCognome.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 73);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Cognome";
            // 
            // txtEta
            // 
            txtEta.Location = new Point(38, 180);
            txtEta.Name = "txtEta";
            txtEta.Size = new Size(321, 23);
            txtEta.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(38, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 23);
            txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 162);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 9;
            label4.Text = "Età";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 206);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Genere";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(401, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(719, 259);
            listBox1.TabIndex = 12;
            // 
            // checkAdin
            // 
            checkAdin.AutoSize = true;
            checkAdin.Location = new Point(38, 262);
            checkAdin.Name = "checkAdin";
            checkAdin.Size = new Size(98, 19);
            checkAdin.TabIndex = 13;
            checkAdin.Text = "Aministratore";
            checkAdin.UseVisualStyleBackColor = true;
            // 
            // checkStudent
            // 
            checkStudent.AutoSize = true;
            checkStudent.Location = new Point(164, 262);
            checkStudent.Name = "checkStudent";
            checkStudent.Size = new Size(73, 19);
            checkStudent.TabIndex = 14;
            checkStudent.Text = "Studente";
            checkStudent.UseVisualStyleBackColor = true;
            // 
            // RadioEsempio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 358);
            Controls.Add(checkStudent);
            Controls.Add(checkAdin);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtEta);
            Controls.Add(label3);
            Controls.Add(txtCognome);
            Controls.Add(label2);
            Controls.Add(rbnM);
            Controls.Add(rbnF);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "RadioEsempio";
            Text = "RadioEsempio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button button1;
        private RadioButton rbnF;
        private RadioButton rbnM;
        private TextBox txtCognome;
        private Label label2;
        private TextBox txtEta;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private CheckBox checkAdin;
        private CheckBox checkStudent;
    }
}