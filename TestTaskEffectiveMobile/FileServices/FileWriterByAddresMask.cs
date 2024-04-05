using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.AddrestStartCommandIsNull;

namespace TestTaskEffectiveMobile.FileServices
{
    public class FileWriterByAddresMask
    {
        private static readonly FileReader _readFile = new();

        public static void Write(FileCommand fileCommand)
        {
            IsValid(fileCommand);

            StreamWriter streamWriter = new StreamWriter(fileCommand.OutputLogFile);
            var text = _readFile.Read(fileCommand);
            var split = text.Split(' ');
            var iterator = 0;

            foreach (var line in split)
            {
                if (line.Contains(fileCommand.AddresStart))
                {
                    streamWriter.WriteLine(line);
                    streamWriter.WriteLine();
                    iterator++;
                }

                if (iterator == fileCommand.AddresMask)
                    break;
            }
            streamWriter.Close();
        }

        private static void IsValid(FileCommand fileCommand)
        {
            if (fileCommand.AddresStart == null)
                throw new AddresCommandFileException();
        }
    }
}