namespace CorsoLinQ
{
    public class Studenti
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; } = 0;
        public string Email { get; set; } = string.Empty;
        public string Corso { get; set; } = string.Empty;
    }
}
