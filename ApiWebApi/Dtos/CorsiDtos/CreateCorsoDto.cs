namespace ApiWebApi.Dtos.CorsiDtos
{
    public class CreateCorsoDto
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descrizione { get; set; }
        public int Crediti { get; set; }
        public int DurataOre { get; set; }

        // Array di interi per ricevere i giorni dal JSON
        public int[] Giorni { get; set; } = Array.Empty<int>();
    }
}
