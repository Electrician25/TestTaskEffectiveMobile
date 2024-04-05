using CommandLine;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.AddrestStartCommandIsNull;

namespace TestTaskEffectiveMobile.FileServices
{
    public class FiileOption
    {
        public static void Options(FileCommand opts, string[] args)
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