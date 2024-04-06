using CommandLine;

namespace TestTaskEffectiveMobile.Commands
{
    public class FileCommand
    {
        [Option('i', "input-log-file", Required = false, HelpText = "specify the path to the log file")]
        public string InputLogFilePath { get; set; }

        [Option('o', "output-log-file", Required = false, HelpText = "specify the path to the log file")]
        public string OutputLogFile { get; set; }

        [Option('d', "address-start", Required = false, HelpText = "order by date")]
        public string AddresStart { get; set; }

        [Option('c', "address-mask", Required = false, HelpText = "specify the path to the log file")]
        public int? AddresMask { get; set; }
    }
}