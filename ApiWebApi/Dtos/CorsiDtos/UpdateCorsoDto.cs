namespace ApiWebApi.Dtos.Corsi
{
    public class UpdateCorsoDto
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descrizione { get; set; }
        public int Crediti { get; set; }
        public int DurataOre { get; set; }

        // Array di interi per i giorni della settimana
        public int[] Giorni { get; set; } = Array.Empty<int>();
    }
}
