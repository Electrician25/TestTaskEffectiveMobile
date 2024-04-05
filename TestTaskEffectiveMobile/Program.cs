using CommandLine;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.AddrestStartCommandIsNull;
using TestTaskEffectiveMobile.FileServices;

namespace StartProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => Options(opts, args));
        }

        private static void Options(FileCommand opts, string[] args)
        {
            if (opts.AddresStart == null && opts.InputLogFilePath != null && opts.OutputLogFile != null && opts.AddresMask == null)
                Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileWriter.WriteAll(opts));

            if (opts.AddresStart != null && opts.InputLogFilePath != null && opts.OutputLogFile != null)
                Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileWriterByDate.Write(opts));

            if (opts.AddresStart != null && opts.InputLogFilePath != null && opts.OutputLogFile != null && opts.AddresMask != null)
                Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FileWriterByAddresMask.Write(opts));
            else throw new AddresCommandFileException();
        }
    }
}