using CommandLine;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.FileServices;

namespace StartProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<FileCommand>(args).WithParsed(opts => FiileOption.Options(opts, args));
        }
    }
}