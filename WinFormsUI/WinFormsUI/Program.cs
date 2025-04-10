using CoreAPI.Core.Randomizers;


namespace WinFormsUI
{
    internal static class Program
    {
        const int workshopsNumber = 9;

        [STAThread] 
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var workshops = WorkshopRandomizer.GenerateMultiple(workshopsNumber);
            Application.Run(new MainForm(workshops.ToList()));

            /*
            Type type = typeof(EditWorkshopForm);
            Application.Run(new TypeMetadataDisplayForm(type));
            */
        }
    }
}