namespace ApiWebApi.Dtos
{
    public class UpdateStudenteDto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; } = 0;
    }
}
