using System.ComponentModel.DataAnnotations;

namespace ApiWebApi.Models
{
    public class Studenti
    {
        [Key]
        public int IdStudente { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(50)]
        public string Cognome { get; set; }
        public int Eta { get; set; } = 0;
    }
}
