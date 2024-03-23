using _3_PL.Views;

namespace _3_PL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmChatLieu());
        }
    }
}