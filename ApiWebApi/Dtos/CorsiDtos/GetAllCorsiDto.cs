namespace ApiWebApi.Dtos.Corsi
{
    public class GetAllCorsiDto
    {
        public int IdCorso { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descrizione { get; set; }
        public int Crediti { get; set; }
        public int DurataOre { get; set; }
        public string Giorni { get; set; } = string.Empty;
    }
}
