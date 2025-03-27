using CoreAPI.Core.Models;

namespace WinFormsUI
{
    internal static class Program
    {
        const int workshopsNumber = 9;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var workshops = WorkshopRandomizer.GenerateMultipleWorkshops(workshopsNumber);
            Application.Run(new MainForm(workshops));
        }
    }
}