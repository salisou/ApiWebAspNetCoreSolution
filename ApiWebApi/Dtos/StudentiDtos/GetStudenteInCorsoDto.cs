namespace ApiWebApi.Dtos.Studenti
{
    /// <summary>
    /// DTO compatto per mostrare gli studenti dentro un corso.
    /// </summary>
    public class GetStudenteInCorsoDto
    {
        public int IdStudente { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
    }
}
