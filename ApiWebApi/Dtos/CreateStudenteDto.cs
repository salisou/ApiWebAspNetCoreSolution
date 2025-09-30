namespace ApiWebApi.Dtos
{
    public class CreateStudenteDto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; } = 0;
    }
}
