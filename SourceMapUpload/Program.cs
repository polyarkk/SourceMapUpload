namespace SourceMapUpload;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    internal static void Main() {
        Console.WriteLine("This console will output progression of map compilcation, do not close!");
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
