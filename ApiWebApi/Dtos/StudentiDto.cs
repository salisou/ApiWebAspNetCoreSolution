using System.ComponentModel.DataAnnotations;

namespace ApiWebApi.Dtos
{
    public class StudentiDto
    {
        public int IdStudente { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
    }
}
