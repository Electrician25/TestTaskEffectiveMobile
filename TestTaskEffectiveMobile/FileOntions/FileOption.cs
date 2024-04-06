using CommandLine;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.AddrestStartCommandIsNull;
using TestTaskEffectiveMobile.FileServices;

namespace TestTaskEffectiveMobile.FileOntions
{
    public class FileOption
    {
        public static void Options(FileCommand command, string[] args)
        {
            if (command.AddresStart == null && command.InputLogFilePath != null && command.OutputLogFile != null && command.AddresMask == null)
                Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileWriter.WriteAll(opts));

            if (command.AddresStart != null && command.InputLogFilePath != null && command.OutputLogFile != null)
                Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileWriterByDate.Write(opts));

            if (command.AddresStart != null && command.InputLogFilePath != null && command.OutputLogFile != null && command.AddresMask != null)
                Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileWriterByAddresMask.Write(opts));
            else throw new AddresCommandFileNotFoundException();
        }
    }
}