namespace Scuola.Desktop.EsempiForms
{
    public partial class ListaBox : Form
    {
        public ListaBox()
        {
            InitializeComponent();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("January");
            listBox1.Items.Add("February");
            listBox1.Items.Add("March");
            listBox1.Items.Add("April");
            listBox1.Items.Add("May");
            listBox1.Items.Add("June");
            listBox1.Items.Add("July");
            listBox1.Items.Add("August");
            listBox1.Items.Add("September");
            listBox1.Items.Add("October");
            listBox1.Items.Add("November");
            listBox1.Items.Add("December");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItems = "Selected Months:\n";
            foreach (var item in listBox1.SelectedItems)
            {
                selectedItems += item.ToString() + "\n";
            }
            MessageBox.Show(selectedItems);
        }
    }
}
