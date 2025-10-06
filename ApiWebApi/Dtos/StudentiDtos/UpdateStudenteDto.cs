namespace ApiWebApi.Dtos.Studenti
{
    public class UpdateStudenteDto
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; } = 0;
        public int IdCorso { get; set; }  // Deve corrispondere a un corso esistente
    }
}
