namespace ApiWebApi.Wrappers
{
    public static class ApiResponseFactory
    {
        public static ApiResponse<T> Success<T>(T data, string message = "Operazione eseguita con successo")
        {
            return new ApiResponse<T>(true, message, data);
        }

        public static ApiResponse<T> Fail<T>(string message, string? error = null)
        {
            return new ApiResponse<T>(false, message, default, error);
        }
    }
}
