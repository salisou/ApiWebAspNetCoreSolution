using Scuola.Desktop.Helpers;

namespace Scuola.Desktop
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void picDashboard_Click(object sender, EventArgs e)
        {
            AlertManager.ShowAlert("Cliccato su Dashboard", "info");
        }

        private void picData_Click(object sender, EventArgs e)
        {
            AlertManager.ShowAlert("Funzionalità del Data Lake non ancora implementata", "warning");
        }

        private void picCorsi_Click(object sender, EventArgs e)
        {
            AlertManager.ShowAlert("Funzionalità dei Corsi non ancora implementata", "warning");
        }

        private void picMonitoraggio_Click(object sender, EventArgs e)
        {
            AlertManager.ShowAlert("Funzionalità del Monitoraggio non ancora implementata", "warning");
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            // Messaggio di warning
            AlertManager.ShowAlert("Funzionalità del Cambia Sfondo non ancora implementata", "warning");
        }
    }
}
