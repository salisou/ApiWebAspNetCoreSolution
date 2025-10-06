using ApiWebApi.Dtos.Studenti;

namespace ApiWebApi.Dtos.Corsi
{
    /// <summary>
    /// DTO dettagliato per ottenere un corso con tutte le informazioni.
    /// </summary>
    public class GetCorsoByIdDto
    {
        public int IdCorso { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descrizione { get; set; }
        public int Crediti { get; set; }
        public int DurataOre { get; set; }

        // Restituisce array di interi invece della stringa
        public int[] Giorni { get; set; } = Array.Empty<int>();

        // lista degli studenti iscritti a questo corso
        public ICollection<GetStudenteInCorsoDto> Studenti { get; set; } = new List<GetStudenteInCorsoDto>();
    }
}
