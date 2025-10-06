using ApiWebApi.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiWebApi.Convert
{
    public class GiorniSettimanaConverter : JsonConverter<GiorniSettimana>
    {
        public override GiorniSettimana Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Legge il numero dal JSON
            int giornoInt = reader.GetInt32();

            // Verifica se è un valore valido dell'enum
            if (Enum.IsDefined(typeof(GiorniSettimana), giornoInt))
            {
                return (GiorniSettimana)giornoInt;
            }

            throw new JsonException($"Valore '{giornoInt}' non valido per GiorniSettimana.");
        }

        public override void Write(Utf8JsonWriter writer, GiorniSettimana value, JsonSerializerOptions options)
        {
            // Scrive il nome del giorno nel JSON
            writer.WriteStringValue(value.ToString());
        }
    }
}
