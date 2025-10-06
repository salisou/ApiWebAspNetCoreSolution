namespace ApiWebApi.Wrappers
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }           // true/false → esito operazione
        public string Message { get; set; }         // messaggio da restituire
        public T? Data { get; set; }                // dati (se presenti)
        public string? Error { get; set; }          // eventuale dettaglio errore

        public ApiResponse(bool success, string message, T? data = default, string? error = null)
        {
            Success = success;
            Message = message;
            Data = data;
            Error = error;
        }
    }
}
