using ApiWebApi.Convert;
using System.Text.Json.Serialization;

namespace ApiWebApi.Models
{
    public class Corsi
    {
        public int IdCorso { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string? Descrizione { get; set; }

        public int Crediti { get; set; }

        public int DurataOre { get; set; }

        /// <summary>
        /// Giorni della settimana in cui si tiene il corso (Flags enum).
        /// </summary>
        [JsonConverter(typeof(GiorniSettimanaConverter))]
        public GiorniSettimana Giorni { get; set; }

        // Relazione 1 corso → N studenti
        public ICollection<Studenti> Studenti { get; set; } = new List<Studenti>();
    }
}
