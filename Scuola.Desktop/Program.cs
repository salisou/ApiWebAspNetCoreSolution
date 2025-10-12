namespace Scuola.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // definizione della pagina principale
            //LoginPage loginForm = new LoginPage();
            HomePage homeForm = new();
            Application.Run(homeForm);
        }
    }
}