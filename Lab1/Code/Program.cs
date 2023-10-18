namespace Lab1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ChangeColorForm form = new ChangeColorForm();
            Application.Run(form);
        }
    }
}