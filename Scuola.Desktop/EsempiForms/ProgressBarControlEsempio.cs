namespace Scuola.Desktop.EsempiForms
{
    public partial class ProgressBarControlEsempio : Form
    {
        public ProgressBarControlEsempio()
        {
            InitializeComponent();
        }

        // Evento che viene eseguito quando il form (finestra) viene caricato
        private void ProgressBarControlEsempio_Load(object sender, EventArgs e)
        {
            // Imposta il valore minimo della ProgressBar (inizio)
            progressBar1.Minimum = 0;

            // Imposta il valore massimo della ProgressBar (fine)
            progressBar1.Maximum = 100;

            // Imposta il valore iniziale (parte da zero)
            progressBar1.Value = 0;

            // Imposta di quanto deve aumentare la barra ad ogni passo
            progressBar1.Step = 2;

            // Imposta l’intervallo del timer a 100 millisecondi (0,1 secondi)
            timer1.Interval = 100;

            // Collega l’evento Tick del timer al metodo Timer1_Tick
            timer1.Tick += Timer1_Tick;

            // Avvia il timer: da questo momento scatterà ogni 0,1 secondi
            timer1.Start();
        }

        // Metodo che viene eseguito automaticamente ogni volta che scatta il timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Se il valore della progress bar è minore del massimo...
            if (progressBar1.Value < progressBar1.Maximum)
            {
                // ...incrementa la barra di un passo (in questo caso +2)
                progressBar1.PerformStep();
            }
            else
            {
                // Se la progress bar ha raggiunto il massimo, ferma il timer
                timer1.Stop();

                // Mostrava un messaggio quando il caricamento finiva (ora è commentato)
                // MessageBox.Show("Il caricamento è completato!");

                // Crea una nuova finestra chiamata HomePage
                HomePage homeForm = new();

                // Mostra la finestra HomePage in modo modale (blocca quella attuale finché non si chiude)
                homeForm.ShowDialog();

                // Chiude il form corrente (quello con la ProgressBar)
                this.Close();
            }
        }

    }
}
