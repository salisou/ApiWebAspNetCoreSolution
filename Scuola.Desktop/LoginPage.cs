
namespace Scuola.Desktop
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtNomeUtente.Text = lblRisultato.Text;
        }
    }
}
