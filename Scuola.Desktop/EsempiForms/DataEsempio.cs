namespace Scuola.Desktop.EsempiForms
{
    public partial class DataEsempio : Form
    {
        public DataEsempio()
        {
            InitializeComponent();
        }

        private void DataEsempio_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = dateTimePicker1.Value;
            lblResult.Text = data.ToString();
        }
    }
}
