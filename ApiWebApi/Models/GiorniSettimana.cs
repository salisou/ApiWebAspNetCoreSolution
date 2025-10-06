namespace ApiWebApi.Models
{
    [Flags] // Permette combinazioni tipo Lunedi | Mercoledi
    public enum GiorniSettimana
    {
        Nessuno = 0,
        Lunedì = 1,
        Martedì = 2,
        Mercoledì = 3,
        Giovedì = 4,
        Venerdì = 5,
        Sabato = 6,
        Domenica = 7
    }
}
