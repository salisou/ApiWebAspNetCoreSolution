namespace Scuola.Desktop.Helpers
{
    public static class AlertManager
    {
        // Percorso predefinito dove cercare le immagini
        private static readonly string basePath = Path.Combine(Application.StartupPath, "images");

        /// <summary>
        /// Mostra un messaggio personalizzato con immagine e colore in base al tipo.
        /// </summary>
        /// <param name="message">Testo del messaggio</param>
        /// <param name="type">Tipo del messaggio: success | warning | error | info</param>
        public static void ShowAlert(string message, string type = "info")
        {
            // Crea finestra base
            Form alert = new Form
            {
                Text = "Avviso",
                Size = new Size(380, 200),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowIcon = false,
                BackColor = Color.White
            };

            // Colori in base al tipo
            Color headerColor;
            Icon systemIcon;

            switch (type.ToLower())
            {
                case "success":
                    headerColor = Color.SeaGreen;
                    systemIcon = SystemIcons.Information;
                    break;
                case "warning":
                    headerColor = Color.Goldenrod;
                    systemIcon = SystemIcons.Warning;
                    break;
                case "error":
                    headerColor = Color.Firebrick;
                    systemIcon = SystemIcons.Error;
                    break;
                case "info":
                    headerColor = Color.SteelBlue;
                    systemIcon = SystemIcons.Information;
                    break;
                default:
                    headerColor = Color.SteelBlue;
                    systemIcon = SystemIcons.Information;
                    break;
            }

            // Pannello superiore
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = headerColor
            };

            Label lblTitle = new Label
            {
                Text = type.ToUpper(),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            headerPanel.Controls.Add(lblTitle);

            // Caricamento immagine
            PictureBox pic = new PictureBox
            {
                Size = new Size(60, 60),
                Location = new Point(25, 60),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string imageFile = Path.Combine(basePath, $"{type.ToLower()}.png");

            if (File.Exists(imageFile))
            {
                pic.Image = Image.FromFile(imageFile);
            }
            else
            {
                // Se l'immagine non esiste, usa un'icona di sistema appropriata
                pic.Image = systemIcon.ToBitmap();
            }

            // Testo del messaggio
            Label lblMessage = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 10),
                AutoSize = false,
                Size = new Size(240, 60),
                Location = new Point(100, 60),
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Pulsante OK
            Button btnOk = new Button
            {
                Text = "OK",
                Size = new Size(80, 30),
                Location = new Point((alert.Width - 100) / 2, 125),
                BackColor = headerColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnOk.Click += (s, e) => alert.Close();

            // Aggiunge i controlli
            alert.Controls.Add(headerPanel);
            alert.Controls.Add(pic);
            alert.Controls.Add(lblMessage);
            alert.Controls.Add(btnOk);

            alert.ShowDialog();
        }
    }
}
