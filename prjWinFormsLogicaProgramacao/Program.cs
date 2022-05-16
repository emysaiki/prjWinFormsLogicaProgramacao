namespace prjWinFormsLogicaProgramacao
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
           //Devo indicar aqui qual formulário ser´o formulário principal
            Application.Run(new MDIParentFrmPrincipal());
        }
    }
}