namespace Scuola.Desktop.EsempiForms
{
    public partial class RadioEsempio : Form
    {
        public RadioEsempio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string email = txtEmail.Text;
            string eta = txtEta.Text;

            if (checkAdin.Checked != true && checkStudent.Checked != true)
            {
                MessageBox.Show("Devi selezionare almeno uno dei due ruoli");
            }
            else
            {
                if (rbnF.Checked == true)
                {
                    listBox1.Items.Add($"Nome: {nome}, Cognome: {cognome}, Email: {email}, Età: {eta}, Sesso: Femmina");
                }
                else if (rbnM.Checked == true)
                {
                    listBox1.Items.Add($"Nome: {nome}, Cognome: {cognome}, Email: {email}, Età: {eta}, Sesso: Maschio");
                }
                else
                {
                    MessageBox.Show("Non hai selezionato il sesso");
                }
            }
        }
    }
}
