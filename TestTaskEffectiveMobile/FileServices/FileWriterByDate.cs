using TestTaskEffectiveMobile.Commands;

namespace TestTaskEffectiveMobile.FileServices
{
    public class FileWriterByDate
    {
        private static readonly FileReader _readFile = new();

        public static void Write(FileCommand fileCommand)
        {
            StreamWriter streamWriter = new(fileCommand.OutputLogFile);
            var text = _readFile.Read(fileCommand);
            var split = text.Split(' ');
            foreach (var line in split)
            {
                if (line.Contains(fileCommand.AddresStart))
                {
                    streamWriter.WriteLine(line);
                    streamWriter.WriteLine();
                }
            }
            streamWriter.Close();
        }
    }
}