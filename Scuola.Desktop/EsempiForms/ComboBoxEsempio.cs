namespace Scuola.Desktop.EsempiForms
{
    public partial class ComboBoxEsempio : Form
    {
        public ComboBoxEsempio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var = comboBox1.Text;
            MessageBox.Show("Hai selezionato: " + var);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text.ToString());
            textBox1.Clear();
        }
    }
}
