using TestTaskEffectiveMobile.Commands;

namespace TestTaskEffectiveMobile.FileServices
{
    public class FileWriter
    {
        private static readonly FileReader _readFile = new();

        public static void WriteAll(FileCommand fileCommand)
        {
            var text = _readFile.Read(fileCommand);

            StreamWriter fileWriter = new(fileCommand.OutputLogFile);
            fileWriter.WriteLine(text);
            fileWriter.Close();
        }
    }
}