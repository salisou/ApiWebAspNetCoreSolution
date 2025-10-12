
using System.Drawing.Drawing2D;

namespace Scuola.Desktop
{
    /// <summary>
    /// Rappresenta la finestra di login dell'applicazione desktop "Scuola".
    /// Gestisce autenticazione, stile dei controlli e interazione con l'utente.
    /// </summary>
    public partial class LoginPage : Form
    {

        // Ho modificato la bordatura della form con FormBorderStyle = none
        // Ho modificato la posizione della form con StartPosition = CenterScreen
        // Ho aggiunto un pannello verde a sinistra
        // Ho aggiunto un'immagine (logo scuola) al centro in alto

        /// <summary>
        /// Percorso base assoluto dove si trovano le immagini per la gestione della password.
        /// </summary>
        private readonly string basePath = @"C:\Users\salis\Desktop\ApiWebAspNetCoreSolution\Scuola.Desktop\images";

        /// <summary>
        /// Indica se la password è attualmente visibile (true) o nascosta (false).
        /// </summary>
        private bool passwordVisibile = false;

        /// <summary>
        /// Costruttore della form LoginPage.
        /// Inizializza i componenti e applica lo stile ai controlli.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            StyleButtonRegister();
            StyleButtonLogin();
            StylePasswordTextBox();
            LoadData();
        }

        /// <summary>
        /// Applica uno stile personalizzato al pulsante di accesso ("Accedi").
        /// </summary>
        private void StyleButtonLogin()
        {
            btnAccedi.FlatStyle = FlatStyle.Flat;
            btnAccedi.FlatAppearance.BorderSize = 2;
            btnAccedi.FlatAppearance.BorderColor = Color.Wheat;
            btnAccedi.BackColor = Color.Lime;
            btnAccedi.ForeColor = Color.White;
            btnAccedi.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Effetti al passaggio del mouse
            btnAccedi.FlatAppearance.MouseOverBackColor = Color.Green;
            btnAccedi.FlatAppearance.MouseDownBackColor = Color.DarkGreen;

            btnAccedi.TabStop = false;
            btnAccedi.UseVisualStyleBackColor = false;
        }

        /// <summary>
        /// Gestisce l’evento di disegno personalizzato del bottone “Accedi”.
        /// Aggiunge bordi arrotondati e un contorno colorato.
        /// </summary>
        private void btnAccedi_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int raggio = 10;
            using (GraphicsPath path = new GraphicsPath())
            {
                // Disegna i 4 angoli arrotondati
                path.AddArc(0, 0, raggio, raggio, 180, 90);
                path.AddArc(btn.Width - raggio - 1, 0, raggio, raggio, 270, 90);
                path.AddArc(btn.Width - raggio - 1, btn.Height - raggio - 1, raggio, raggio, 0, 90);
                path.AddArc(0, btn.Height - raggio - 1, raggio, raggio, 90, 90);
                path.CloseFigure();

                // Imposta il contorno arrotondato
                btn.Region = new Region(path);

                using (Pen pen = new Pen(Color.Wheat, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        /// <summary>
        /// Applica lo stile grafico al pulsante "Registrati".
        /// </summary>
        private void StyleButtonRegister()
        {
            btnRegiter.FlatStyle = FlatStyle.Flat;
            btnRegiter.FlatAppearance.BorderSize = 2;
            btnRegiter.FlatAppearance.BorderColor = Color.Blue;
            btnRegiter.BackColor = Color.Transparent;
            btnRegiter.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Pulisce i campi di testo e imposta il focus sul campo nome.
        /// </summary>
        private void LoadData()
        {
            txtNome.Clear();
            txtPassword.Clear();
            txtNome.Focus();
        }

        /// <summary>
        /// Chiude la finestra corrente.
        /// </summary>
        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Gestisce il click sul pulsante "Accedi".
        /// Verifica le credenziali inserite e, se corrette, apre la home page.
        /// </summary>
        private void btnAccedi_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtNome.Text;
                string password = txtPassword.Text;

                // Verifica che entrambi i campi siano compilati
                if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
                {
                    // Credenziali hardcoded (solo per esempio)
                    if (username == "Moussa" && password == "admin")
                    {
                        this.Hide(); // Nasconde la pagina di login
                        HomePage homeForm = new HomePage();
                        homeForm.ShowDialog(); // Mostra la home
                        this.Close(); // Chiude il login dopo la chiusura della home
                    }
                    else
                    {
                        MessageBox.Show("Credenziali non valide", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Per favore, inserisci sia il nome utente che la password.", "Errore di accesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Eseguito sempre, anche in caso di eccezione
                LoadData();
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante "Registrati".
        /// Attualmente mostra solo un messaggio informativo.
        /// </summary>
        private void btnRegiter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funzionalità di registrazione non ancora implementata.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Imposta lo stile iniziale del campo password e del PictureBox per la visibilità.
        /// </summary>
        private void StylePasswordTextBox()
        {
            txtPassword.UseSystemPasswordChar = true; // Nasconde la password
            string imagePath = Path.Combine(basePath, "view.png");

            // Verifica che il file esista prima di caricarlo
            if (File.Exists(imagePath))
                picPasswordToggle.Image = Image.FromFile(imagePath);
            else
                MessageBox.Show($"Immagine non trovata: {imagePath}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            picPasswordToggle.SizeMode = PictureBoxSizeMode.Zoom;
            picPasswordToggle.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Gestisce il click sull’icona per mostrare/nascondere la password.
        /// Alterna l’immagine tra "view" e "hide" e aggiorna la visibilità del testo.
        /// </summary>
        private void picPasswordToggle_Click(object sender, EventArgs e)
        {
            passwordVisibile = !passwordVisibile;

            string viewPath = Path.Combine(basePath, "view.png");
            string hidePath = Path.Combine(basePath, "hide.png");

            if (passwordVisibile)
            {
                txtPassword.UseSystemPasswordChar = false;

                if (File.Exists(hidePath))
                    picPasswordToggle.Image = Image.FromFile(hidePath);
                else
                    MessageBox.Show($"Immagine non trovata: {hidePath}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

                if (File.Exists(viewPath))
                    picPasswordToggle.Image = Image.FromFile(viewPath);
                else
                    MessageBox.Show($"Immagine non trovata: {viewPath}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
