﻿using CommandLine;

namespace TestTaskEffectiveMobile.Commands
{
    public class FileCommand
    {
        [Option('i', "input-log-file", Required = false, HelpText = "specify the path to the log file")]
        public string InputLogFilePath { get; set; }

        [Option('o', "output-log-file", Required = false, HelpText = "specify the path to the log file")]
        public string OutputLogFile { get; set; }

        [Option('a', "address-start", Required = false, HelpText = "order by date")]
        public string AddresStart { get; set; }

        [Option('m', "address-mask", Required = false, HelpText = "specify the path to the log file")]
        public string AddresMask { get; set; }
    }
}