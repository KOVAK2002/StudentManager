namespace StudentManager
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
           
           Login_Form flogin= new Login_Form();
            if(flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main_Form());

            }
            else
            {
                Application.Exit();
            }
        }
    }
}